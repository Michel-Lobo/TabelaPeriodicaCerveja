using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using TabelaCervejaAPI.Models;

namespace TabelaCervejaAPI.Config
{
    public class MapEstiloCerveja: EntityTypeConfiguration<EstiloCerveja>
    {
        public MapEstiloCerveja()
        {
            HasKey(p => p.IDEstilo);
            Property(p => p.IDEstilo).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(p => p.DescricaoEstilo)
                .HasMaxLength(5000);
            Property(p=> p.Exemplos)
                .HasMaxLength(5000);

            HasRequired(p => p.GrupoEstilo)
                .WithMany(p => p.EstilosCeveja)
                .HasForeignKey(p => p.IDGrupoEstilo);
       
        }
    }
}