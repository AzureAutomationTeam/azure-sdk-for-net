// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.VideoSearch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for VideoQueryScenario.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VideoQueryScenario
    {
        [EnumMember(Value = "List")]
        List,
        [EnumMember(Value = "SingleDominantVideo")]
        SingleDominantVideo
    }
    internal static class VideoQueryScenarioEnumExtension
    {
        internal static string ToSerializedValue(this VideoQueryScenario? value)
        {
            return value == null ? null : ((VideoQueryScenario)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this VideoQueryScenario value)
        {
            switch( value )
            {
                case VideoQueryScenario.List:
                    return "List";
                case VideoQueryScenario.SingleDominantVideo:
                    return "SingleDominantVideo";
            }
            return null;
        }

        internal static VideoQueryScenario? ParseVideoQueryScenario(this string value)
        {
            switch( value )
            {
                case "List":
                    return VideoQueryScenario.List;
                case "SingleDominantVideo":
                    return VideoQueryScenario.SingleDominantVideo;
            }
            return null;
        }
    }
}
