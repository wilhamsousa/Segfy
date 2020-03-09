using System;
using System.Collections.Generic;
using System.Text;

namespace Segfy.Domain.Entities
{
    public class Playlist
    {
        public string playlistId { get; set; }
        public string YoutbeObjectId { get; set; }
        public YoutubeObject YoutbeObject { get; set; }
    }
}
