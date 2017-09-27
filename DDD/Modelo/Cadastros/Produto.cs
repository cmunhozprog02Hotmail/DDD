using Modelo.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Cadastros
{
    public class Produto
    {
        public long? ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public long? CategoriaId { get; set; }

        public long? FabricanteId { get; set; }

        public virtual Fabricante Fabricante { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}
