// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.VideoSearch.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class VideosModule
    {
        /// <summary>
        /// Initializes a new instance of the VideosModule class.
        /// </summary>
        public VideosModule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideosModule class.
        /// </summary>
        public VideosModule(IList<VideoObject> value = default(IList<VideoObject>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<VideoObject> Value { get; private set; }

    }
}
