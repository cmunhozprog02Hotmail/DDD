﻿using Presistencia.DAL.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using Modelo.Cadastros;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Cadastros
{
    public class ProdutoServico
    {
        private ProdutoDAL produtoDAL = new ProdutoDAL();

        public IQueryable ObterProdutosClassificadosPorNome()
        {
            return produtoDAL.ObterProdutosClassificadosPorNome();
        }

        public Produto ObterProdutoPorId(long id)
        {
            return produtoDAL.ObterProdutoPorId(id);
        }

        public void GravarProduto(Produto produto)
        {
            produtoDAL.GravarProduto(produto);
        }

        public Produto EliminarProdutoPorId(long id)
        {
            return produtoDAL.EliminarProdutoPorId(id);
        }
    }
}
