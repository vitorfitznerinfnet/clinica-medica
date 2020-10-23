using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Clinica.WebApp.Models;

namespace Clinica.WebApp.DataAccess
{
    public class BancoDeDados
    {
        static List<Paciente> pacientes = new List<Paciente>();

        public void Armazenar(Paciente paciente)
        {
            pacientes.Add(paciente);
        }

        public List<Paciente> BuscarPacientes()
        {
            return pacientes;
        }

        public List<Paciente> BuscarPacientesPeloNome(string nome)
        {
            if (nome == null)
            { 
                return pacientes;
            }

            List<Paciente> novaListaDePacientes = new List<Paciente>();

            foreach (var paciente in pacientes)
            { 
                if (paciente.Nome.Contains(nome))
                {
                    novaListaDePacientes.Add(paciente);
                }
            }

            return novaListaDePacientes;
        }
    }
}
