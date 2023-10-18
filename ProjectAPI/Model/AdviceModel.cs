using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ProjectAPI.Model
{
    public class AdviceModel
    {
         [JsonPropertyName("id")]
        public int? Id{ get; set; }

        [JsonPropertyName("advice")]
        public string? Advice { get; set; }
    }
}
