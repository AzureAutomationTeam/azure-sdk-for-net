// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// Definition of the connection fields.
    /// </summary>
    public partial class FieldDefinition
    {
        /// <summary>
        /// Initializes a new instance of the FieldDefinition class.
        /// </summary>
        public FieldDefinition()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FieldDefinition class.
        /// </summary>
        /// <param name="type">Gets or sets the type of the connection field
        /// definition.</param>
        /// <param name="isEncrypted">Gets or sets the isEncrypted flag of the
        /// connection field definition.</param>
        /// <param name="isOptional">Gets or sets the isOptional flag of the
        /// connection field definition.</param>
        public FieldDefinition(string type, bool? isEncrypted = default(bool?), bool? isOptional = default(bool?))
        {
            this.IsEncrypted = isEncrypted;
            this.IsOptional = isOptional;
            this.Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the isEncrypted flag of the connection field
        /// definition.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isEncrypted")]
        public bool? IsEncrypted { get; set; }

        /// <summary>
        /// Gets or sets the isOptional flag of the connection field
        /// definition.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isOptional")]
        public bool? IsOptional { get; set; }

        /// <summary>
        /// Gets or sets the type of the connection field definition.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Type == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
