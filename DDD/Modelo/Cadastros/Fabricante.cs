using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Cadastros
{
    public class Fabricante
    {
        public long? FabricanteId { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
