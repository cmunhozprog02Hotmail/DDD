using Modelo.Cadastros;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Tabelas
{
    public class Categoria
    {
        
        public long? CategoriaId { get; set; }

        //[Required(ErrorMessage = "O este campo é requerido")]

        public string Nome { get; set; }

        //public string Observacao { get; set; }

        //public bool teste { get; set; }

        public string Teste02 { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
