// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create or update runbook operation.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class RunbookCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the RunbookCreateOrUpdateParameters
        /// class.
        /// </summary>
        public RunbookCreateOrUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RunbookCreateOrUpdateParameters
        /// class.
        /// </summary>
        /// <param name="runbookType">Gets or sets the type of the runbook.
        /// Possible values include: 'Script', 'Graph', 'PowerShellWorkflow',
        /// 'PowerShell', 'GraphPowerShellWorkflow', 'GraphPowerShell'</param>
        /// <param name="logVerbose">Gets or sets verbose log option.</param>
        /// <param name="logProgress">Gets or sets progress log option.</param>
        /// <param name="draft">Gets or sets the draft runbook
        /// properties.</param>
        /// <param name="publishContentLink">Gets or sets the published runbook
        /// content link.</param>
        /// <param name="description">Gets or sets the description of the
        /// runbook.</param>
        /// <param name="logActivityTrace">Gets or sets the activity-level
        /// tracing options of the runbook.</param>
        /// <param name="name">Gets or sets the name of the resource.</param>
        /// <param name="location">Gets or sets the location of the
        /// resource.</param>
        /// <param name="tags">Gets or sets the tags attached to the
        /// resource.</param>
        public RunbookCreateOrUpdateParameters(string runbookType, bool? logVerbose = default(bool?), bool? logProgress = default(bool?), RunbookDraft draft = default(RunbookDraft), ContentLink publishContentLink = default(ContentLink), string description = default(string), int? logActivityTrace = default(int?), string name = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>))
        {
            this.LogVerbose = logVerbose;
            this.LogProgress = logProgress;
            this.RunbookType = runbookType;
            this.Draft = draft;
            this.PublishContentLink = publishContentLink;
            this.Description = description;
            this.LogActivityTrace = logActivityTrace;
            this.Name = name;
            this.Location = location;
            this.Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

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
        /// Gets or sets the type of the runbook. Possible values include:
        /// 'Script', 'Graph', 'PowerShellWorkflow', 'PowerShell',
        /// 'GraphPowerShellWorkflow', 'GraphPowerShell'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.runbookType")]
        public string RunbookType { get; set; }

        /// <summary>
        /// Gets or sets the draft runbook properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.draft")]
        public RunbookDraft Draft { get; set; }

        /// <summary>
        /// Gets or sets the published runbook content link.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.publishContentLink")]
        public ContentLink PublishContentLink { get; set; }

        /// <summary>
        /// Gets or sets the description of the runbook.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the activity-level tracing options of the runbook.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.logActivityTrace")]
        public int? LogActivityTrace { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the location of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the tags attached to the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.RunbookType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "RunbookType");
            }
            if (this.Draft != null)
            {
                this.Draft.Validate();
            }
            if (this.PublishContentLink != null)
            {
                this.PublishContentLink.Validate();
            }
        }
    }
}
