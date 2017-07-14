using System.Collections.Generic;
using Newtonsoft.Json;

namespace TabelaCervejaAPI.Models
{
    public class GrupoEstilo
    {
        public int IDGrupoEstilo { get; set; }
        public string NomeGrupo { get; set; }
        [JsonIgnore]
        public virtual ICollection<EstiloCerveja> EstilosCeveja { get; set; }
    }
}