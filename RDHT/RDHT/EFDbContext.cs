using RDHT.Entity;
using RDHT.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RDHT
{
    public class EFDbContext:DbContext
    {
        public EFDbContext() : base("EFDbContext")
        {

        }
        public IDbSet<News> news
        {
            get;
            set;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new NewsConfiguration());
        }
    }
  
}