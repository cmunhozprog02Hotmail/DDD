using System;
using System.Net;
using System.Web.Mvc;
using Modelo.Cadastros;
using Servico.Cadastros;

namespace Apresentacao.Controllers
{
    public class FabricantesController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        private FabricanteServico fabricanteServico = new FabricanteServico();

        // Para delete edit e details
        private ActionResult ObterVisaoFabricantePorId(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Fabricante fabricante = fabricanteServico.ObterFabricantePorId((long)id);
            if (fabricante == null)
            {
                return HttpNotFound();
            }
            return View(fabricante);
        }

        // HTTP Salvar
        private ActionResult GravarFabricante(Fabricante fabricante)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //produtoServico.GravarProduto(produto);
                    fabricanteServico.GravarFabricante(fabricante);
                    return RedirectToAction("Index");
                }
                return View(fabricante);
            }
            catch
            {
                return View(fabricante);
            }
        }

        // GET: Fabricantes
        public ActionResult Index()
        {
            //return View(produtoServico.ObterProdutosClassificadosPorNome());
            return View(fabricanteServico.ObterFabricantesClassificadosPorNome());
        }

        // GET: Fabricantes/Details/5
        public ActionResult Details(long? id)
        {
            //return ObterVisaoProdutoPorId(id);
            return ObterVisaoFabricantePorId(id);
        }

        // GET: Fabricantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fabricantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FabricanteId,Nome")] Fabricante fabricante)
        {
            if (ModelState.IsValid)
            {
                //return GravarProduto(produto);
                return GravarFabricante(fabricante);
            }

            return View(fabricante);
        }

        // GET: Fabricantes/Edit/5
        public ActionResult Edit(long? id)
        {
            // return ObterVisaoProdutoPorId(id);
            return ObterVisaoFabricantePorId(id);
        }

        // POST: Fabricantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FabricanteId,Nome")] Fabricante fabricante)
        {
            if (ModelState.IsValid)
            {
                return GravarFabricante(fabricante);
            }
            return View(fabricante);
        }

        // GET: Fabricantes/Delete/5
        public ActionResult Delete(long? id)
        {
            //return ObterVisaoProdutoPorId(id);
            return ObterVisaoFabricantePorId(id);
        }

        // POST: Fabricantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            /* try
             {
                 Produto produto = produtoServico.EliminarProdutoPorId(id);
                 TempData["Message"] = "Produto " + produto.Nome.ToUpper() + " foi removido";
                 return RedirectToAction("Index");

             }
             catch (System.Exception)
             {

                 throw;
             }*/

            try
            {
                Fabricante fabricante = fabricanteServico.EliminarFabricantePorId(id);
                TempData["Message"] = "Produto " + fabricante.Nome.ToUpper() + " foi removido";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
