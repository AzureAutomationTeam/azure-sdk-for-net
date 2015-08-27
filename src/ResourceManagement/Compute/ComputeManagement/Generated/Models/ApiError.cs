namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Api error.
    /// </summary>
    public partial class ApiError
    {
        /// <summary>
        /// Gets or sets the Api error details
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ApiErrorBase> Details { get; set; }

        /// <summary>
        /// Gets or sets the Api inner error
        /// </summary>
        [JsonProperty(PropertyName = "innererror")]
        public InnerError Innererror { get; set; }

        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the target of the particular error.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}