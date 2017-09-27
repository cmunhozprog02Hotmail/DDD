using Modelo.Tabelas;
using Presistencia.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using Modelo.Cadastros;
using System.Threading.Tasks;

namespace Presistencia.DAL.Cadastros
{
    public class CategoriaDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Categoria> ObterCategoriasClassificadasPorNome()
        {
            return context.Categorias.OrderBy(b => b.Nome);
        }
    }
}
