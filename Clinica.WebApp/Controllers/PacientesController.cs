using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Clinica.WebApp.Models;
using Clinica.WebApp.DataAccess;
using System.Linq;
using Clinica.WebApp.Validacoes;

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
            var model = new CadastroModel();
            model.Erros = new List<string>();
            return View(model);
        }

        [HttpPost]
        public ActionResult Cadastro(string nome, string cpf, string email)
        {
            var listaDeErros = new List<string>();

            bool nomeContemAlgumDigito = nome.Any(char.IsDigit);

            if (nomeContemAlgumDigito == true)
            {
                listaDeErros.Add("Nome contém números");
            }

            bool cpfEhValido = ValidaCPF.EhCpfValido(cpf);

            if (cpfEhValido == false)
            {
                listaDeErros.Add("CPF é inválido");
            }

            //Email é válido


            //não posso ter mais de 1 paciente com o CPF




            var cadastroModel = new CadastroModel();
            cadastroModel.Erros = new List<string>();

            if (listaDeErros.Count > 0)
            {
                cadastroModel.Erros = listaDeErros;

                return View(cadastroModel);
            }

            Paciente paciente = new Paciente();
            paciente.Nome = nome;
            paciente.Cpf = cpf;
            paciente.Email = email;

            BancoDeDados bancoDeDados = new BancoDeDados();
            bancoDeDados.Armazenar(paciente);

            return View(cadastroModel);
        }

        [HttpGet]
        public ActionResult Consulta(string q)
        {
            BancoDeDados bancoDeDados = new BancoDeDados();

            var pacientes = bancoDeDados.BuscarPacientesPeloNome(q);

            return View(pacientes);
        }

        //[HttpPost]
        //public ActionResult Consulta(string q)
        //{
        //    BancoDeDados bancoDeDados = new BancoDeDados();

        //    var pacientes = bancoDeDados.BuscarPacientesPeloNome(q);

        //    return View(pacientes);
        //}

        public ActionResult Index()
        {
            return View();
        }
    }
}