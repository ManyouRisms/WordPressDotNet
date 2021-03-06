﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressDotNet.Models
{
    public class Media
    {
        public int id { get; set; }
        public string date { get; set; }
        public string date_gmt { get; set; }
        public Guid guid { get; set; }
        public string modified { get; set; }
        public string modified_gmt { get; set; }
        public string slug { get; set; }
        public string type { get; set; }
        public string link { get; set; }
        public Title title { get; set; }
        public int author { get; set; }
        public string comment_status { get; set; }
        public string ping_status { get; set; }
        public Meta meta { get; set; }
        public string alt_text { get; set; }
        public string caption { get; set; }
        public string description { get; set; }
        public string media_type { get; set; }
        public string mime_type { get; set; }
        public MediaDetails media_details { get; set; }
        public int? post { get; set; }
        public string source_url { get; set; }
        public _Links _links { get; set; }
    }
}
