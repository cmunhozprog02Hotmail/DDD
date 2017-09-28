﻿using Modelo.Cadastros;
using System.Collections.Generic;

namespace Modelo.Tabelas
{
    public class Categoria
    {
        public long? CategoriaId { get; set; }

        public string Nome { get; set; }

        public string Observacao { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
