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
    }
}
