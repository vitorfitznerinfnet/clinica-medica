using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica.WebApp.Models;
using Clinica.WebApp.DataAccess;

namespace Clinica.WebApp.Controllers
{
    public class PacientesController : Controller
    {
        static List<Paciente> pacientes = new List<Paciente>();

        public ActionResult Lista()
        {
            return View(pacientes);
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(string nome, string cpf)
        {
            Paciente paciente = new Paciente();
            paciente.Nome = nome;
            paciente.Cpf = cpf;

            pacientes.Add(paciente);

            BancoDeDados bancoDeDados = new BancoDeDados();
            bancoDeDados.Armazenar(pacientes);

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