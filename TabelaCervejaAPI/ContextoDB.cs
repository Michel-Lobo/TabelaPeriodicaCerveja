using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TabelaCervejaAPI.Config;
using TabelaCervejaAPI.Models;

namespace TabelaCervejaAPI
{
    public class ContextoDB: DbContext

    {
        public DbSet<EstiloCerveja> EstiloCerveja { get; set; }
        public DbSet<GrupoEstilo> GrupoEstilo { get; set; }
        public ContextoDB():
            base(@"Data Source=DESKTOP-VP4BAVB\SQLEXPRESS2014;Initial Catalog=TabelaCervejaDB;Integrated Security=True;MultipleActiveResultSets=True")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties()
               .Where(p => p.PropertyType.Name == "string")
               .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties()
                 .Where(p => p.PropertyType.Name == "string")
                 .Configure(p => p.HasMaxLength(50));

            modelBuilder.Configurations.Add(new MapEstiloCerveja());
            modelBuilder.Configurations.Add(new MapGrupoEstilo());
        }
    }
}