using System;
using System.Collections.Generic;
using System.Text;

namespace Segfy.Domain.ValueObject
{
    public class YoutubeId
    {
        public string kind { get; set; }
        public string playlistId { get; set; }
        public string videoId { get; set; }
    }
}
