using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Clinica.WebApp.Models;
using Clinica.WebApp.DataAccess;

namespace Clinica.WebApp.Controllers
{
    public class PacientesController : Controller
    {
        public ActionResult Lista()
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            var pacientes = bancoDeDados.BuscarPacientes();
            return View(pacientes);
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(string nome, string cpf, string email)
        {
            Paciente paciente = new Paciente();
            paciente.Nome = nome;
            paciente.Cpf = cpf;
            paciente.Email = email;

            BancoDeDados bancoDeDados = new BancoDeDados();
            bancoDeDados.Armazenar(paciente);

            return View();
        }

        [HttpGet]
        public ActionResult Consulta()
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            
            var pacientes = bancoDeDados.BuscarPacientes();

            return View(pacientes);
        }

        [HttpPost]
        public ActionResult Consulta(string q)
        {
            //utilizar a variavel Q para fazer a minha consulta

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }    
}