using System;
using System.Collections.Generic;
using System.Text;
using static Segfy.Domain.Enum.Enun;

namespace Segfy.Domain.Entities
{
    public class Youtube
    {
        public string Id { get; set; }
        public Kind Kind { get; set; }
        public string PublishedAt { get; set; }
        public string ChannelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string DefaultUrl { get; set; }
        public int DefaultWidth { get; set; }
        public int DefaultHeight { get; set; }

        public string MediumUrl { get; set; }
        public int MediumWidth { get; set; }
        public int MediumHeight { get; set; }

        public string HighUrl { get; set; }
        public int HighWidth { get; set; }
        public int HighHeight { get; set; }

        public string ChannelTitle { get; set; }
        public string LiveBroadcastContent { get; set; }
    }
}
