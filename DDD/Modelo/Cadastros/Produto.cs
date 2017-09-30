using Modelo.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Cadastros
{
    public class Produto
    {
        [Display (Name = "id")]
        public long? ProdutoId { get; set; }

        [StringLength(200, ErrorMessage = "O nome do produto precisa ter no mínimo 10 caracteres")]
        [Required(ErrorMessage = "Informe o nome do produto")]
        public string Nome { get; set; }

        [Display(Name = "Data de Cadastro")]
        //[Required(ErrorMessage = "Informe a data de cadastro do produto")]
        public DateTime? DataCadastro { get; set; }

        [Display(Name = "Categoria")]
        public long? CategoriaId { get; set; }

        [Display(Name = "Fabricante")]
        public long? FabricanteId { get; set; }

        public virtual Fabricante Fabricante { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}
