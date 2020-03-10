
using Newtonsoft.Json;
using static Segfy.Domain.Enum.Enun;

namespace Segfy.Domain.ValueObject
{
    public class YoutubeObject
    {
        [JsonProperty(PropertyName = "id")]
        public YoutubeId id { get; set; }
        public Snippet snippet { get; set; }
    }
}
