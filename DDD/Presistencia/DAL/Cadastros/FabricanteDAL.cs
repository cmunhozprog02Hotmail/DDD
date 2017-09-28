using Modelo.Cadastros;
using Presistencia.Contexts;
using System.Linq;
using System.Data.Entity;
namespace Presistencia.DAL.Cadastros
{
    public class FabricanteDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Fabricante> ObterFabricantesClassificadoPorNome()
        {
            return context.Fabricantes.OrderBy(b => b.Nome);
        }
        public Fabricante ObterFabricantePorId(long id)
        {
            return context.Fabricantes.Where(f => f.FabricanteId == id).First();
           
        }

        public void GravarFabricante(Fabricante fabricante)
        {
            if (fabricante.FabricanteId == null)
            {
                context.Fabricantes.Add(fabricante);
            }
            else
            {
                context.Entry(fabricante).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public Fabricante EliminarProdutoPorId(long id)
        {
            Fabricante fabricante = ObterFabricantePorId(id);
            //context.Produtos.Remove(produto);
            context.Fabricantes.Remove(fabricante);
            context.SaveChanges();
            return fabricante;
        }
    }
}
