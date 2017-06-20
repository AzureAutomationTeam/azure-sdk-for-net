// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// Definition of the credential.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Credential
    {
        /// <summary>
        /// Initializes a new instance of the Credential class.
        /// </summary>
        public Credential()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Credential class.
        /// </summary>
        /// <param name="id">Gets the id of the resource.</param>
        /// <param name="name">Gets the name of the credential.</param>
        /// <param name="userName">Gets the user name of the
        /// credential.</param>
        /// <param name="creationTime">Gets the creation time.</param>
        /// <param name="lastModifiedTime">Gets the last modified time.</param>
        /// <param name="description">Gets or sets the description.</param>
        public Credential(string id = default(string), string name = default(string), string userName = default(string), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), string description = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.UserName = userName;
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
        /// Gets the id of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the user name of the credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.userName")]
        public string UserName { get; private set; }

        /// <summary>
        /// Gets the creation time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the last modified time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

    }
}
