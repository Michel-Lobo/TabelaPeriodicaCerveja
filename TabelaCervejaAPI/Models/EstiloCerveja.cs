using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TabelaCervejaAPI.Models
{
    public class EstiloCerveja
    {
        public int IDEstilo { get; set; }
        public int IDGrupoEstilo { get; set; }
        [JsonIgnore]
        public virtual GrupoEstilo GrupoEstilo { get; set; }
        public string NomeEstilo { get; set; }
        public string DescricaoEstilo { get; set; }
        public string GravidadeInicial { get; set; }
        public string GravidadeFinal { get; set; }
        public string IBU { get; set; }
        public string ABV { get; set; }
        public string SRM { get; set; }
        public string Exemplos { get; set; }
    }
}