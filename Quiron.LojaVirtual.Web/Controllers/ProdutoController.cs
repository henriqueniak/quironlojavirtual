﻿using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private PordutosRepositorios _repositorio;
        // GET: Produto
        public ActionResult Index()
        {
            _repositorio = new PordutosRepositorios();
            var produtos = _repositorio.Produtos.Take(10);
            return View(produtos);
        }
    }
}