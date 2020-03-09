
using Newtonsoft.Json;
using static Segfy.Domain.Enum.Enun;

namespace Segfy.Domain.Entities
{
    public class YoutubeObject
    {
        [JsonIgnore]
        public decimal Id { get; set; }

        [JsonProperty(PropertyName = "id")]
        public YoutubeId YoutubeId { get; set; }
        public Snippet snippet { get; set; }
        
        [JsonIgnore]
        public Kind Kind { get; set; }
    }
}
