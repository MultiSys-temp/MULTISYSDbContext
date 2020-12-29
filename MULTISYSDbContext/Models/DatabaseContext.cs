using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System.IO;
using System.Reflection;
using System.Text;

namespace MULTISYSDbContext.Models
{

    [DbConfigurationType(typeof(SQLiteConfiguration))]
    //[DbConfigurationType("MULTISYSPlugin.SQLiteConfiguration, MULTISYSPlugin2021")]
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() :
            base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "BIMGO.sqlite"), ForeignKeys = true}.ConnectionString
            }, true)
        {
            //Database.CreateIfNotExists();

        }

        /*public DatabaseContext() :
            base("Data Source=BIMGO.db; Version=3;")
        {
            //Database.CreateIfNotExists();

        }*/


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<DatabaseContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        

        public DbSet<LOT> LOTs { get; set; }
    }
}
