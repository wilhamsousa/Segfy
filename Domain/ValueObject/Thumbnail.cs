using System;
using System.Collections.Generic;
using System.Text;

namespace Segfy.Domain.ValueObject
{
    public class Thumbnail
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }        
    }
}
