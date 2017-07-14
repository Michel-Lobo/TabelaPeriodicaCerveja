using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using TabelaCervejaAPI.Models;

namespace TabelaCervejaAPI.Config
{
    public class MapGrupoEstilo: EntityTypeConfiguration<GrupoEstilo>
    {
        public MapGrupoEstilo()
        {
            HasKey(p => p.IDGrupoEstilo);
            Property(p => p.IDGrupoEstilo)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}