using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDHT.Models
{
    public class @News
    {
        public Guid news_guid { get; set; }
        public string title { get; set; }
        public DateTime creat_time { get; set; }

        public string author { set; get; }

        public string news_source { set; get; }
        public string context { set; get; }
    }
}