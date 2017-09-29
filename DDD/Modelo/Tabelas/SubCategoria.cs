using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Tabelas
{
    public class SubCategoria
    {
        public long? SubCategoriaId { get; set; }

        public string Nome { get; set; }

        public long? CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

        
    }
}
