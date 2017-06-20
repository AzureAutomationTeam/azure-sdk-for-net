// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create or update configuration
    /// operation.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class DscConfigurationCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DscConfigurationCreateOrUpdateParameters class.
        /// </summary>
        public DscConfigurationCreateOrUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DscConfigurationCreateOrUpdateParameters class.
        /// </summary>
        /// <param name="source">Gets or sets the source.</param>
        /// <param name="logVerbose">Gets or sets verbose log option.</param>
        /// <param name="logProgress">Gets or sets progress log option.</param>
        /// <param name="parameters">Gets or sets the configuration
        /// parameters.</param>
        /// <param name="description">Gets or sets the description of the
        /// configuration.</param>
        /// <param name="name">Gets or sets name of the resource.</param>
        /// <param name="location">Gets or sets the location of the
        /// resource.</param>
        /// <param name="tags">Gets or sets the tags attached to the
        /// resource.</param>
        public DscConfigurationCreateOrUpdateParameters(ContentSource source, bool? logVerbose = default(bool?), bool? logProgress = default(bool?), System.Collections.Generic.IDictionary<string, DscConfigurationParameter> parameters = default(System.Collections.Generic.IDictionary<string, DscConfigurationParameter>), string description = default(string), string name = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>))
        {
            this.LogVerbose = logVerbose;
            this.LogProgress = logProgress;
            this.Source = source;
            this.Parameters = parameters;
            this.Description = description;
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
        /// Gets or sets the source.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.source")]
        public ContentSource Source { get; set; }

        /// <summary>
        /// Gets or sets the configuration parameters.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.parameters")]
        public System.Collections.Generic.IDictionary<string, DscConfigurationParameter> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the description of the configuration.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets name of the resource.
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
            if (this.Source == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Source");
            }
            if (this.Source != null)
            {
                this.Source.Validate();
            }
        }
    }
}
