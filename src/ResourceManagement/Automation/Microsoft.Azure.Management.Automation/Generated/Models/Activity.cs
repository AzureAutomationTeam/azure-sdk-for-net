// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// Definition of the activity.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Activity
    {
        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        public Activity()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        /// <param name="id">Gets or sets the id of the resource.</param>
        /// <param name="name">Gets the name of the activity.</param>
        /// <param name="definition">Gets or sets the user name of the
        /// activity.</param>
        /// <param name="parameterSets">Gets or sets the parameter sets of the
        /// activity.</param>
        /// <param name="outputTypes">Gets or sets the output types of the
        /// activity.</param>
        /// <param name="creationTime">Gets or sets the creation time.</param>
        /// <param name="lastModifiedTime">Gets or sets the last modified
        /// time.</param>
        /// <param name="description">Gets or sets the description.</param>
        public Activity(string id = default(string), string name = default(string), string definition = default(string), System.Collections.Generic.IList<ActivityParameterSet> parameterSets = default(System.Collections.Generic.IList<ActivityParameterSet>), System.Collections.Generic.IList<ActivityOutputType> outputTypes = default(System.Collections.Generic.IList<ActivityOutputType>), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), string description = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Definition = definition;
            this.ParameterSets = parameterSets;
            this.OutputTypes = outputTypes;
            this.CreationTime = creationTime;
            this.LastModifiedTime = lastModifiedTime;
            this.Description = description;
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
        /// Gets the name of the activity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the user name of the activity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.definition")]
        public string Definition { get; set; }

        /// <summary>
        /// Gets or sets the parameter sets of the activity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.parameterSets")]
        public System.Collections.Generic.IList<ActivityParameterSet> ParameterSets { get; set; }

        /// <summary>
        /// Gets or sets the output types of the activity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.outputTypes")]
        public System.Collections.Generic.IList<ActivityOutputType> OutputTypes { get; set; }

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

    }
}
