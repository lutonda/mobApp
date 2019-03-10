using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mobgo.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace mobgo
{
    public class Context : DbContext
    {
        public Context() : base("Context")
        {
        }

        public DbSet<User> Users{ get; set; }
        public DbSet<Currency> Currencies{ get; set; }
        public DbSet<License> Licenses{ get; set; }
        public DbSet<Pack> Packs{ get; set; }
        public DbSet<Sync> Syncs{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}