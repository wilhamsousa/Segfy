using Newtonsoft.Json;

namespace Segfy.Domain.Entities
{
    public class thumbnails
    {
        [JsonProperty(PropertyName = "default")]
        public Thumbnail DefaultValue { get; set; }
        public Thumbnail medium { get; set; }
        public Thumbnail high { get; set; }
    }
}
