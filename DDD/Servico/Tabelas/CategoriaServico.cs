using Modelo.Tabelas;
using Presistencia.DAL.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Cadastros
{
    public class CategoriaServico
    {
        private CategoriaDAL CategoriaDAL = new CategoriaDAL();

        public IQueryable<Categoria> ObterCategoriasClassificadasPorNome()
        {
            return CategoriaDAL.ObterCategoriasClassificadasPorNome();
        }
    }
}
