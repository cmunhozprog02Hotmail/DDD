using Modelo.Cadastros;
using Presistencia.DAL.Cadastros;
using System.Linq;

namespace Servico.Cadastros
{
    public class FabricanteSetvico
    {
        private FabricanteDAL fabricanteDAL = new FabricanteDAL();

        public IQueryable<Fabricante> ObterFabricantesClassificadosPorNome()
        {
            return fabricanteDAL.ObterFabricantesClassificadoPorNome();
        }


    }
}
