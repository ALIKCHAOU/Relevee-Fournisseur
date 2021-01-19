﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retenu_Fournisseur.Model
{
 public  class ContextApplication : DbContext
    {
        public ContextApplication() : base("AppDB")
        {
            // Database.SetInitializer(new MigrateDatabaseToLatestVersion<SAPXRTDbContext, Configuration>());
          //  Database.SetInitializer<SAPXRTDbContext>(new CreateDatabaseIfNotExists<SAPXRTDbContext>());
        }

      
        public DbSet<User> Users { get; set; }
    
    }
}