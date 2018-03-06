using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDHT.Entity
{
    public class News
    {
        public Guid news_guid { set; get; }
        public string title { set; get; }
        public DateTime creat_time { set; get; }
        public string author { set; get; }
        public string news_source { set; get; }
        public string context { set; get; }
    }
}