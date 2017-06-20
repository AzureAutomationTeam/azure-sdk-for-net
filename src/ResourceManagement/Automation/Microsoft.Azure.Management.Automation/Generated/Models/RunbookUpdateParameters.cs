// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the update runbook operation.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class RunbookUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the RunbookUpdateParameters class.
        /// </summary>
        public RunbookUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RunbookUpdateParameters class.
        /// </summary>
        /// <param name="description">Gets or sets the description of the
        /// runbook.</param>
        /// <param name="logVerbose">Gets or sets verbose log option.</param>
        /// <param name="logProgress">Gets or sets progress log option.</param>
        /// <param name="logActivityTrace">Gets or sets the activity-level
        /// tracing options of the runbook.</param>
        /// <param name="name">Gets or sets the name of the resource.</param>
        /// <param name="location">Gets or sets the location of the
        /// resource.</param>
        /// <param name="tags">Gets or sets the tags attached to the
        /// resource.</param>
        public RunbookUpdateParameters(string description = default(string), bool? logVerbose = default(bool?), bool? logProgress = default(bool?), int? logActivityTrace = default(int?), string name = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>))
        {
            this.Description = description;
            this.LogVerbose = logVerbose;
            this.LogProgress = logProgress;
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
        /// Gets or sets the description of the runbook.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

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

    }
}
