using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;
using WebApplication7.ViewModels;
using static WebApplication7.MvcApplication;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        private Model1 _db;
        public HomeController()
        {
            _db = new Model1();
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase uploadFile)
        {
            var _upload = uploadFile;
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";



            return View();
        }

        [NoDirectAccess]
        public ActionResult Contact()
        {
            var _clientes = (from p in _db.TB_Cliente
                             select p).ToList();
            List<ClienteViewModel> lstCliente = new List<ClienteViewModel>();
            foreach (var item in _clientes)
            {
                lstCliente.Add(new ClienteViewModel()
                {
                    Id = item.ID_Cliente,
                    Nome = item.DS_Nome,
                    DataHora = item.DT_Inclusao,
                    Atualizar = item.DS_Nome == "Lucca Xavier" || item.DS_Nome == "Thais Pereira" ? true : false
                });
            }
            return View(lstCliente);
        }
        [HttpPost]
        public ActionResult Contact(ClienteViewModel model)
        {
            TB_Cliente _cliente = new TB_Cliente();
            _cliente.DS_Nome = model.Nome;
            _cliente.DT_Inclusao = DateTime.Now;
            _db.TB_Cliente.Add(_cliente);
            _db.SaveChanges();
            return View();
        }
    }
}