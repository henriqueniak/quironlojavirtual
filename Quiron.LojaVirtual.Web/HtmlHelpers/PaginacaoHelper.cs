using Quiron.LojaVirtual.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelper
    {
        public static MvcHtmlString pageLink(this HtmlHelper html,  Paginacao paginacao, Func<int, string> paginaUrl)
        {
            StringBuilder resultado = new StringBuilder();
            for (int i = 1; i <= paginacao.TotalPaginas; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.AddCssClass("btn btn-default");
                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString();

                if (i == paginacao.PaginaAtual)
                    tag.AddCssClass("selected btn-primaty");
                resultado.Append(tag);

            }

            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}