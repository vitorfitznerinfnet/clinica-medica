using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.WebApp.Controllers
{
    public class PacientesController : Controller
    {
        public string Lista()
        {
            return "Olá";
        }

        public ActionResult Cadastro(string nome, string cpf)
        {
            return View();
        }

        public ActionResult Consulta()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}