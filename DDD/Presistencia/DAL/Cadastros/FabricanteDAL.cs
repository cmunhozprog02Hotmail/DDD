using Modelo.Cadastros;
using Presistencia.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presistencia.DAL.Cadastros
{
    public class FabricanteDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Fabricante> ObterFabricantesClassificadoPorNome()
        {
            return context.Fabricantes.OrderBy(b => b.Nome);
        }
    }
}
