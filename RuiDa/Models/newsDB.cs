using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RuiDa1.Models
{
    public class newsDB
    {
        //[Required(ErrorMessage = "不能为空")]
        //[StringLength(36)]
        public Guid news_guid { get; set; }
        
        public string title{ get; set; }

        public DateTime creat_time { get; set; }
        public string author { get; set; }

        public string news_source { get; set; }

        public string context { get; set; }

    }
}