using RDHT.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace RDHT.EntityConfiguration
{

    public class NewsConfiguration : EntityTypeConfiguration<News>
    {
        public NewsConfiguration()
        {
            this.ToTable("News");
            this.HasKey(x => x.news_guid);
        }
    }
}