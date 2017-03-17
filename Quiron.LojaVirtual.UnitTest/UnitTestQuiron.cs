using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiron.LojaVirtual.Web.Models;
using Quiron.LojaVirtual.Web.HtmlHelpers;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuiron
    {
        [TestMethod]
        public void TestarPaginacao()
        {
            //Arrange
            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao()
            {
                ItensTotal = 28,
                ItensPorPagina = 10,
                PaginaAtual = 2
            };

           Func<int, string> paginaUrl = i => "Pagina" + i;

           //Act
           MvcHtmlString resultado = html.pageLink(paginacao, paginaUrl);
           
            //Assert
            Assert.AreEqual("<a class=\"btn btn-default\" href=\"Pagina1\">1</a>"+
            "<a class=\"selected btn-primaty btn btn-default\" href=\"Pagina2\">2</a>"+
            "<a class=\"btn btn-default\" href=\"Pagina3\">3</a>", resultado.ToString());

        }
    }
}
