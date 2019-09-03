using SiteUtilizandoAspNetMvc4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SiteUtilizandoAspNetMvc4.Repository
{
        public class DefaultDBContext : DbContext,IDBSource
        {
            public DefaultDBContext() : base("DefaultConnection") {}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author> Author { get; set; }

         IQueryable<Author> IDBSource.Author { get { return Author; } }
    }

}