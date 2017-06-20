// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// Definition of the job schedule.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class JobSchedule
    {
        /// <summary>
        /// Initializes a new instance of the JobSchedule class.
        /// </summary>
        public JobSchedule()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobSchedule class.
        /// </summary>
        /// <param name="id">Gets or sets the id of the resource.</param>
        /// <param name="jobScheduleId">Gets or sets the id of job
        /// schedule.</param>
        /// <param name="schedule">Gets or sets the schedule.</param>
        /// <param name="runbook">Gets or sets the runbook.</param>
        /// <param name="runOn">Gets or sets the hybrid worker group that the
        /// scheduled job should run on.</param>
        /// <param name="parameters">Gets or sets the parameters of the job
        /// schedule.</param>
        public JobSchedule(string id = default(string), string jobScheduleId = default(string), ScheduleAssociationProperty schedule = default(ScheduleAssociationProperty), RunbookAssociationProperty runbook = default(RunbookAssociationProperty), string runOn = default(string), System.Collections.Generic.IDictionary<string, string> parameters = default(System.Collections.Generic.IDictionary<string, string>))
        {
            this.Id = id;
            this.JobScheduleId = jobScheduleId;
            this.Schedule = schedule;
            this.Runbook = runbook;
            this.RunOn = runOn;
            this.Parameters = parameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the id of job schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.jobScheduleId")]
        public string JobScheduleId { get; set; }

        /// <summary>
        /// Gets or sets the schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.schedule")]
        public ScheduleAssociationProperty Schedule { get; set; }

        /// <summary>
        /// Gets or sets the runbook.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.runbook")]
        public RunbookAssociationProperty Runbook { get; set; }

        /// <summary>
        /// Gets or sets the hybrid worker group that the scheduled job should
        /// run on.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.runOn")]
        public string RunOn { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the job schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.parameters")]
        public System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

    }
}
