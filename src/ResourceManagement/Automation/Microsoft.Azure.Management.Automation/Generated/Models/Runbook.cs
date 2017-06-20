// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// Definition of the runbook type.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Runbook : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Runbook class.
        /// </summary>
        public Runbook()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Runbook class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="runbookType">Gets or sets the type of the runbook.
        /// Possible values include: 'Script', 'Graph', 'PowerShellWorkflow',
        /// 'PowerShell', 'GraphPowerShellWorkflow', 'GraphPowerShell'</param>
        /// <param name="publishContentLink">Gets or sets the published runbook
        /// content link.</param>
        /// <param name="state">Gets or sets the state of the runbook. Possible
        /// values include: 'New', 'Edit', 'Published'</param>
        /// <param name="logVerbose">Gets or sets verbose log option.</param>
        /// <param name="logProgress">Gets or sets progress log option.</param>
        /// <param name="logActivityTrace">Gets or sets the option to log
        /// activity trace of the runbook.</param>
        /// <param name="jobCount">Gets or sets the job count of the
        /// runbook.</param>
        /// <param name="parameters">Gets or sets the runbook
        /// parameters.</param>
        /// <param name="outputTypes">Gets or sets the runbook output
        /// types.</param>
        /// <param name="draft">Gets or sets the draft runbook
        /// properties.</param>
        /// <param name="provisioningState">Gets or sets the provisioning state
        /// of the runbook. Possible values include: 'Succeeded'</param>
        /// <param name="lastModifiedBy">Gets or sets the last modified
        /// by.</param>
        /// <param name="creationTime">Gets or sets the creation time.</param>
        /// <param name="lastModifiedTime">Gets or sets the last modified
        /// time.</param>
        /// <param name="description">Gets or sets the description.</param>
        /// <param name="etag">Gets or sets the etag of the resource.</param>
        public Runbook(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string runbookType = default(string), ContentLink publishContentLink = default(ContentLink), string state = default(string), bool? logVerbose = default(bool?), bool? logProgress = default(bool?), int? logActivityTrace = default(int?), int? jobCount = default(int?), System.Collections.Generic.IDictionary<string, RunbookParameter> parameters = default(System.Collections.Generic.IDictionary<string, RunbookParameter>), System.Collections.Generic.IList<string> outputTypes = default(System.Collections.Generic.IList<string>), RunbookDraft draft = default(RunbookDraft), RunbookProvisioningState? provisioningState = default(RunbookProvisioningState?), string lastModifiedBy = default(string), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), string description = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            this.RunbookType = runbookType;
            this.PublishContentLink = publishContentLink;
            this.State = state;
            this.LogVerbose = logVerbose;
            this.LogProgress = logProgress;
            this.LogActivityTrace = logActivityTrace;
            this.JobCount = jobCount;
            this.Parameters = parameters;
            this.OutputTypes = outputTypes;
            this.Draft = draft;
            this.ProvisioningState = provisioningState;
            this.LastModifiedBy = lastModifiedBy;
            this.CreationTime = creationTime;
            this.LastModifiedTime = lastModifiedTime;
            this.Description = description;
            this.Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of the runbook. Possible values include:
        /// 'Script', 'Graph', 'PowerShellWorkflow', 'PowerShell',
        /// 'GraphPowerShellWorkflow', 'GraphPowerShell'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.runbookType")]
        public string RunbookType { get; set; }

        /// <summary>
        /// Gets or sets the published runbook content link.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.publishContentLink")]
        public ContentLink PublishContentLink { get; set; }

        /// <summary>
        /// Gets or sets the state of the runbook. Possible values include:
        /// 'New', 'Edit', 'Published'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets verbose log option.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.logVerbose")]
        public bool? LogVerbose { get; set; }

        /// <summary>
        /// Gets or sets progress log option.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.logProgress")]
        public bool? LogProgress { get; set; }

        /// <summary>
        /// Gets or sets the option to log activity trace of the runbook.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.logActivityTrace")]
        public int? LogActivityTrace { get; set; }

        /// <summary>
        /// Gets or sets the job count of the runbook.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.jobCount")]
        public int? JobCount { get; set; }

        /// <summary>
        /// Gets or sets the runbook parameters.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.parameters")]
        public System.Collections.Generic.IDictionary<string, RunbookParameter> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the runbook output types.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.outputTypes")]
        public System.Collections.Generic.IList<string> OutputTypes { get; set; }

        /// <summary>
        /// Gets or sets the draft runbook properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.draft")]
        public RunbookDraft Draft { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the runbook. Possible values
        /// include: 'Succeeded'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public RunbookProvisioningState? ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the creation time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the last modified time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the etag of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.PublishContentLink != null)
            {
                this.PublishContentLink.Validate();
            }
            if (this.Draft != null)
            {
                this.Draft.Validate();
            }
        }
    }
}
