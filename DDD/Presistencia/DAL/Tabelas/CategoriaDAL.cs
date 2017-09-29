﻿using Modelo.Tabelas;
using Presistencia.Contexts;
using System.Data.Entity;
using System.Linq;


namespace Presistencia.DAL.Cadastros
{
    public class CategoriaDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Categoria> ObterCategoriasClassificadasPorNome()
        {
            return context.Categorias.OrderBy(b => b.Nome);
        }

        public Categoria ObterCategoriaPorId(long id)
        {
            return context.Categorias.Where(c => c.CategoriaId == id).First();
        }

        public void GravarCategoria(Categoria categoria)
        {
            if (categoria.CategoriaId == null)
            {
                context.Categorias.Add(categoria);
            }
            else
            {
                context.Entry(categoria).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public Categoria EliminarCategoriaPorId(long id)
        {
            Categoria categoria = ObterCategoriaPorId(id);
            context.Categorias.Remove(categoria);
            context.SaveChanges();
            return categoria;
        }
    }
}
   

