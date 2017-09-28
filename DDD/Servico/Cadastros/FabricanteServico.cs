using Modelo.Cadastros;
using Presistencia.DAL.Cadastros;
using System.Linq;

namespace Servico.Cadastros
{
    public class FabricanteServico
    {
        private FabricanteDAL fabricanteDAL = new FabricanteDAL();

        public IQueryable<Fabricante> ObterFabricantesClassificadosPorNome()
        {
            return fabricanteDAL.ObterFabricantesClassificadoPorNome();
        }
        public Fabricante ObterFabricantePorId(long id)
        {
            return fabricanteDAL.ObterFabricantePorId(id);
        }

        public void GravarFabricante(Fabricante fabricante)
        {
            //produtoDAL.GravarProduto(produto);
            fabricanteDAL.GravarFabricante(fabricante);
        }

        public Fabricante EliminarFabricantePorId(long id)
        {
            //return produtoDAL.EliminarProdutoPorId(id);
            return fabricanteDAL.EliminarProdutoPorId(id);
        }


    }
}
