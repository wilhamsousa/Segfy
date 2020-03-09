using Segfy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Segfy.Domain.ValueObject
{
    public class searchListResponse
    {
        public string kind { get; set; }
        public List<YoutubeObject> items { get; set; }
    }
}
