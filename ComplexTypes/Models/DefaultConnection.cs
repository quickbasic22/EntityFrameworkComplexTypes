using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace ComplexTypes.Models
{
    public class DefaultConnection : DbContext
    {
        public DefaultConnection() : base("name=DefaultConnection")
        { 
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Person> People { get; set; }
        
        
    }
}