using Modelo.Tabelas;
using Presistencia.DAL.Cadastros;
using System.Linq;

namespace Servico.Cadastros
{
    public class CategoriaServico
    {
        private CategoriaDAL CategoriaDAL = new CategoriaDAL();

        public IQueryable<Categoria> ObterCategoriasClassificadasPorNome()
        {
            return CategoriaDAL.ObterCategoriasClassificadasPorNome();
        }
        public Categoria ObterCategoriaPorId(long id)
        {
            return CategoriaDAL.ObterCategoriaPorId(id);
        }

        public void GravarCategoria(Categoria categoria)
        {
            CategoriaDAL.GravarCategoria(categoria);
        }

        public Categoria EliminarCategoriaPorId(long id)
        {
            return CategoriaDAL.EliminarCategoriaPorId(id);
        }
    }
}
