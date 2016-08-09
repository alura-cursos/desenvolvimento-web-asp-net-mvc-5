using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaelumEstoque.DAO;
using CaelumEstoque.Models;
namespace CaelumEstoque.Controllers
{
    public class ContadorController : Controller
    {
        public ActionResult Index()
        {
            int contador = Convert.ToInt32(Session["contador"]);
            contador++;
            Session["contador"] = contador;
            return View(contador);
        }
    }
}