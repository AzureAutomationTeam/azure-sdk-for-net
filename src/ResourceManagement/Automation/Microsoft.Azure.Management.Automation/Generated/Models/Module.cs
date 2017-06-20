// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// Definition of the module type.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Module : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Module class.
        /// </summary>
        public Module()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Module class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="isGlobal">Gets or sets the isGlobal flag of the
        /// module.</param>
        /// <param name="version">Gets or sets the version of the
        /// module.</param>
        /// <param name="sizeInBytes">Gets or sets the size in bytes of the
        /// module.</param>
        /// <param name="activityCount">Gets or sets the activity count of the
        /// module.</param>
        /// <param name="provisioningState">Gets or sets the provisioning state
        /// of the module. Possible values include: 'Created', 'Creating',
        /// 'StartingImportModuleRunbook', 'RunningImportModuleRunbook',
        /// 'ContentRetrieved', 'ContentDownloaded', 'ContentValidated',
        /// 'ConnectionTypeImported', 'ContentStored', 'ModuleDataStored',
        /// 'ActivitiesStored', 'ModuleImportRunbookComplete', 'Succeeded',
        /// 'Failed', 'Cancelled', 'Updating'</param>
        /// <param name="contentLink">Gets or sets the contentLink of the
        /// module.</param>
        /// <param name="error">Gets or sets the error info of the
        /// module.</param>
        /// <param name="creationTime">Gets or sets the creation time.</param>
        /// <param name="lastModifiedTime">Gets or sets the last modified
        /// time.</param>
        /// <param name="description">Gets or sets the description.</param>
        /// <param name="etag">Gets or sets the etag of the resource.</param>
        public Module(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), bool? isGlobal = default(bool?), string version = default(string), long? sizeInBytes = default(long?), int? activityCount = default(int?), ModuleProvisioningState? provisioningState = default(ModuleProvisioningState?), ContentLink contentLink = default(ContentLink), ModuleErrorInfo error = default(ModuleErrorInfo), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), string description = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            this.IsGlobal = isGlobal;
            this.Version = version;
            this.SizeInBytes = sizeInBytes;
            this.ActivityCount = activityCount;
            this.ProvisioningState = provisioningState;
            this.ContentLink = contentLink;
            this.Error = error;
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
        /// Gets or sets the isGlobal flag of the module.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isGlobal")]
        public bool? IsGlobal { get; set; }

        /// <summary>
        /// Gets or sets the version of the module.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the size in bytes of the module.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sizeInBytes")]
        public long? SizeInBytes { get; set; }

        /// <summary>
        /// Gets or sets the activity count of the module.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.activityCount")]
        public int? ActivityCount { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the module. Possible values
        /// include: 'Created', 'Creating', 'StartingImportModuleRunbook',
        /// 'RunningImportModuleRunbook', 'ContentRetrieved',
        /// 'ContentDownloaded', 'ContentValidated', 'ConnectionTypeImported',
        /// 'ContentStored', 'ModuleDataStored', 'ActivitiesStored',
        /// 'ModuleImportRunbookComplete', 'Succeeded', 'Failed', 'Cancelled',
        /// 'Updating'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public ModuleProvisioningState? ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the contentLink of the module.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.contentLink")]
        public ContentLink ContentLink { get; set; }

        /// <summary>
        /// Gets or sets the error info of the module.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.error")]
        public ModuleErrorInfo Error { get; set; }

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
            if (this.ContentLink != null)
            {
                this.ContentLink.Validate();
            }
        }
    }
}
