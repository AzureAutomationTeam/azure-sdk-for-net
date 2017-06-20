// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;
using Microsoft.Azure.Management.Resources.Models;
using Microsoft.Azure.Test;
using Microsoft.Rest.Azure;
using Newtonsoft.Json;
using Microsoft.Azure.Management.Resources;

namespace Microsoft.Azure.Management.Automation.Testing
{
    public class AutomationTestBase : TestBase, IDisposable
    {
        private const string resourceGroup = "SDKTestResourceGroup";
        private const string automationAccount = "SDKTestAccount";
        private const string location = "East Us";
        
        public AutomationTestBase()
        {
            var handler = new RecordedDelegatingHandler();
            AutomationClient = ResourceGroupHelper.GetAutomationClient(handler);

            ResourceManagementClient resourcesClient = ResourceGroupHelper.GetResourcesClient(handler);

            try
            {
                resourcesClient.ResourceGroups.CreateOrUpdate(resourceGroup,
                new ResourceGroup
                {
                    Location = location
                });

                AutomationAccountsOperationsExtensions.CreateOrUpdate(this.AutomationClient.AutomationAccounts, automationAccount,  new AutomationAccountCreateOrUpdateParameters
                {
                    Name = automationAccount,
                    Location = location,
                    Properties = new AutomationAccountCreateOrUpdateProperties()
                    {
                        Sku = new Sku() { Name = "Free", Family = "Test", Capacity = 1 }
                    }
                }, resourceGroup);
            }
            catch (CloudException ex)
            {
                if (ex.Response.StatusCode != System.Net.HttpStatusCode.Conflict) throw;
            }


            // Clean up the automation account, delete runbooks, schedules, variables, etc.
            //this.CleanUpCredentials();
            this.CleanUpRunbooks();
            //this.CleanUpSchedules();
            //this.CleanUpVariables();
            //this.CleanUpWebhooks();
        }

        public IAutomationClient AutomationClient { get; private set; }

        //public void CleanUpCredentials()
        //{
        //    IList<Credential> credentials = AutomationClient.PsCredentials.List(resourceGroup, automationAccount).Credentials;

        //    foreach (Credential cr in credentials)
        //    {
        //        this.DeleteCredential(cr.Name);
        //    }
        //}

        public void CleanUpRunbooks()
        {
            var runbooks = RunbooksOperationsExtensions.ListByAutomationAccount(AutomationClient.Runbooks, automationAccount, resourceGroup);

            var enumerator = runbooks.GetEnumerator();

            var runbook = enumerator.Current;
            while (runbook != null)
            { 
                this.DeleteRunbook(runbook.Name);
                enumerator.MoveNext();
                runbook = enumerator.Current;
            }
        }

        //public void CleanUpSchedules()
        //{
        //    IList<Schedule> schedules = this.AutomationClient.Schedules.List(resourceGroup, automationAccount).Schedules;

        //    foreach (Schedule schedule in schedules)
        //    {
        //        this.DeleteSchedule(schedule.Name);
        //    }
        //}

        //public void CleanUpVariables()
        //{
        //    IList<Variable> variables = this.AutomationClient.Variables.List(resourceGroup, automationAccount).Variables;

        //    foreach (Variable variable in variables)
        //    {
        //        this.DeleteVariable(variable.Name);
        //    }
        //}

        //public void CleanUpWebhooks()
        //{
        //    IList<Webhook> webhooks = this.AutomationClient.Webhooks.List(resourceGroup, automationAccount, null).Webhooks;

        //    foreach (var webhook in webhooks)
        //    {
        //        this.DeleteWebhook(webhook.Name);
        //    }
        //}

        //public Credential CreateCredential(string credentialName, string userName, string password, string description = null)
        //{

        //    var response = AutomationClient.PsCredentials.CreateOrUpdate(resourceGroup, automationAccount, new CredentialCreateOrUpdateParameters
        //    {
        //        Name = credentialName,
        //        Properties = new CredentialCreateOrUpdateProperties
        //        {
        //            UserName = userName,
        //            Password = password,
        //            Description = description
        //        }
        //    });
        //    return response.Credential;
        //}

        //public Webhook CreateWebhook(string webhookName, string runbookName, string uri, string description = null)
        //{
        //    var response = AutomationClient.Webhooks.CreateOrUpdate(resourceGroup, automationAccount, new WebhookCreateOrUpdateParameters
        //    {
        //        Name = webhookName,
        //        Properties = new WebhookCreateOrUpdateProperties
        //        {
        //            Runbook = new RunbookAssociationProperty
        //            {
        //                Name = runbookName
        //            },
        //            Uri = uri,
        //            IsEnabled = true,
        //            ExpiryTime = DateTime.Now.AddYears(1)
        //        }
        //    });
        //    return response.Webhook;
        //}

        //public string GenerateUriForWebhook()
        //{
        //    return AutomationClient.Webhooks.GenerateUri(resourceGroup, automationAccount).Uri;
        //}

        public void CreateRunbook(string runbookName, string runbookContent, string description = null)
        {
            RunbookDraftOperationsExtensions.Create(AutomationClient.RunbookDraft,
                automationAccount,
                new RunbookCreateOrUpdateDraftParameters
                {
                    Name = runbookName,
                    Location = location,
                    Properties = new RunbookCreateOrUpdateDraftProperties
                    {
                        Description = description,
                        RunbookType = RunbookTypeEnum.Script,
                        Draft = new RunbookDraft()
                    }
                },
                resourceGroup);

            //this.UpdateRunbookContent(runbookName, runbookContent);
        }

        public Schedule CreateHourlySchedule(string scheduleName, DateTime startTime,
            DateTime expiryTime, string description = null, byte hourInterval = 1)
        {
            var schedule = SchedulesOperationsExtensions.CreateOrUpdate(AutomationClient.Schedules,
                automationAccount,
                scheduleName,
                new ScheduleCreateOrUpdateParameters
                {
                    Name = scheduleName,
                    Properties = new ScheduleCreateOrUpdateProperties
                    {
                        StartTime = startTime.ToUniversalTime(),
                        ExpiryTime = expiryTime.ToUniversalTime(),
                        Description = description,
                        Interval = hourInterval,
                        Frequency = ScheduleFrequency.Hour.ToString()
                    }
                },
                resourceGroup);
            
            return schedule;
        }

        //public Variable CreateVariable(string variableName, object value, string description = null)
        //{
        //    var response = AutomationClient.Variables.CreateOrUpdate(resourceGroup, automationAccount, new VariableCreateOrUpdateParameters
        //    {
        //        Name = variableName,
        //        Properties = new VariableCreateOrUpdateProperties
        //        {
        //            Value = JsonConvert.SerializeObject(value),
        //            Description = description
        //        }
        //    });
        //    return response.Variable;
        //}

        public void DeleteCredential(string credentialName)
        {
            AutomationClient.PsCredentials.Delete(resourceGroup, automationAccount, credentialName);
        }

        public void DeleteRunbook(string runbookName)
        {
            AutomationClient.Runbooks.Delete(resourceGroup, automationAccount, runbookName);
        }

        public void DeleteSchedule(string scheduleName)
        {
            AutomationClient.Schedules.Delete(resourceGroup, automationAccount, scheduleName);
        }

        public void DeleteVariable(string variableName)
        {
            AutomationClient.Variables.Delete(resourceGroup, automationAccount, variableName);
        }

        public void DeleteWebhook(string webhookName)
        {
            AutomationClient.Webhooks.Delete(resourceGroup, automationAccount, webhookName);
        }

        //public Credential GetCredential(string credentialName)
        //{
        //    var response = AutomationClient.PsCredentials.Get(resourceGroup, automationAccount, credentialName);
        //    return response.Credential;
        //}

        //public IList<Credential> GetCredentials()
        //{
        //    var response = AutomationClient.PsCredentials.List(resourceGroup, automationAccount);
        //    return response.Credentials;
        //}

        //public IList<JobStream> GetJobStreams(Guid jobId, string streamType, DateTime startTime)
        //{
        //    var response = AutomationClient.JobStreams.List(resourceGroup, automationAccount, jobId, new JobStreamListParameters
        //    {
        //        Time = string.Format(CultureInfo.InvariantCulture, "{0:O}", startTime.ToUniversalTime()),
        //        StreamType = streamType
        //    });

        //    return response.JobStreams;
        //}

        public Runbook GetRunbook(string runbookName)
        {
            var runbook = RunbooksOperationsExtensions.Get(AutomationClient.Runbooks,
                automationAccount,
                runbookName,
                resourceGroup);
            return runbook;
        }

        public string GetRunbookContent(string runbookName)
        {
            var response = RunbookDraftOperationsExtensions.GetContent(AutomationClient.RunbookDraft,
                automationAccount,
                runbookName,
                resourceGroup);
            var stream = response.ToString();
            return stream;
        }

        public Schedule GetSchedule(string scheduleName)
        {
            var schedule = SchedulesOperationsExtensions.Get(AutomationClient.Schedules,
                automationAccount,
                scheduleName,
                resourceGroup);
            var response = AutomationClient.Schedules.Get(resourceGroup, automationAccount, scheduleName);
            return schedule;
        }

        //public Variable GetVariable(string variableName)
        //{
        //    var response = AutomationClient.Variables.Get(resourceGroup, automationAccount, variableName);
        //    return response.Variable;
        //}

        //public IList<Variable> GetVariables()
        //{
        //    var response = AutomationClient.Variables.List(resourceGroup, automationAccount);
        //    return response.Variables;
        //}

        //public Webhook GetWebhook(string webhookName)
        //{
        //    var response = AutomationClient.Webhooks.Get(resourceGroup, automationAccount, webhookName);
        //    return response.Webhook;
        //}

        //public IList<Webhook> GetWebhooks(string runbookName = null)
        //{
        //    var response = AutomationClient.Webhooks.List(resourceGroup, automationAccount, runbookName);
        //    return response.Webhooks;
        //}

        public void PublishRunbook(string runbookName)
        {
            RunbookDraftOperationsExtensions.BeginPublish(AutomationClient.RunbookDraft,
                automationAccount,
                runbookName,
                resourceGroup);
        }

        //public Job StartRunbook(string runbookName, IDictionary<string, string> parameters = null)
        //{
        //    var response = AutomationClient.Jobs.Create(resourceGroup, automationAccount, new JobCreateParameters
        //    {
        //        Properties = new JobCreateProperties
        //        {
        //            Runbook = new RunbookAssociationProperty
        //            {
        //                Name = runbookName
        //            },
        //            Parameters = parameters
        //        }
        //    });
        //    return response.Job;
        //}

        //public void UpdateCredential(Credential credential, string password = null)
        //{
        //    AutomationClient.PsCredentials.Patch(resourceGroup, automationAccount, new CredentialUpdateParameters
        //    {
        //        Name = credential.Name,
        //        Properties = new CredentialUpdateProperties
        //        {
        //            UserName = credential.Properties.UserName,
        //            Password = password,
        //            Description = credential.Properties.Description
        //        }
        //    });
        //}

        public void UpdateRunbook(Runbook runbook)
        {
            RunbooksOperationsExtensions.Update(AutomationClient.Runbooks,
                automationAccount,
                runbook.Name,
                 new RunbookUpdateParameters
                 {
                     Name = runbook.Name,
                     Properties = new RunbookUpdateProperties
                     {
                         Description = runbook.Properties.Description,
                         LogProgress = runbook.Properties.LogProgress,
                         LogVerbose = runbook.Properties.LogVerbose
                     }
                 },
                 resourceGroup);
        }

        //public void UpdateRunbookContent(string runbookName, string runbookContent)
        //{
        //    RunbookDraftOperationsExtensions.Create(AutomationClient.RunbookDraft,
        //        automationAccount,
        //         new RunbookCreateOrUpdateDraftParameters
        //         {
        //             Name = runbookName,
        //             Properties = new RunbookCreateOrUpdateDraftProperties
        //             {

        //             }
        //         });
        //        )

        //    //AutomationClient.RunbookDraft.BeginUpdate(resourceGroup, automationAccount, new RunbookDraftUpdateParameters
        //    //{
        //    //    Name = runbookName,
        //    //    Stream = runbookContent
        //    //});
        //}

        //public void UpdateSchedule(Schedule schedule)
        //{
        //    SchedulesOperationsExtensions.Update(AutomationClient.Schedules,
        //        automationAccount,
        //        schedule.Name,
        //        new ScheduleUpdateParameters
        //        {
        //            Name = schedule.Name,
        //            Properties = new ScheduleUpdateProperties
        //            {
        //                IsEnabled = schedule.Properties.IsEnabled,
        //                Description = schedule.Properties.Description
        //            }
        //        },
        //        resourceGroup);
        //}

        //public void UpdateVariable(Variable variable)
        //{
        //    AutomationClient.Variables.Patch(resourceGroup, automationAccount, new VariableUpdateParameters
        //    {
        //        Name = variable.Name,
        //        Properties = new VariableUpdateProperties
        //        {
        //            Value = variable.Properties.Value,
        //            Description = variable.Properties.Description
        //        }
        //    });
        //}

        //public void UpdateWebhook(Webhook webhook)
        //{
        //    AutomationClient.Webhooks.UpdateWithHttpMessagesAsync(resourceGroup, automationAccount, new WebhookUpdateParameters
        //    {
        //        Name = webhook.Name,
        //        Properties = new WebhookUpdateProperties
        //        {
        //            IsEnabled = webhook.Properties.IsEnabled
        //        }
        //    });
        //}

        //public Job WaitForJobCompletion(Guid jobId, string expectedState = "Completed", int numRetries = 50)
        //{
        //    var response = AutomationClient.Jobs.Get(resourceGroup, automationAccount, jobId);
        //    string[] endStates = new string[4] { "Stopped", "Suspended", "Failed", "Completed" };
        //    var job = response.Job;
        //    var retry = 0;
        //    while (job.Properties.Status != expectedState && retry < numRetries && !Array.Exists(endStates, s => s == job.Properties.Status))
        //    {
        //        TestUtilities.Wait(6000);
        //        job = AutomationClient.Jobs.Get(resourceGroup, automationAccount, jobId).Job;
        //        retry++;
        //    }

        //    return job;
        //}

        public void Dispose()
        {
            AutomationClient.Dispose();
        }
    }
}
