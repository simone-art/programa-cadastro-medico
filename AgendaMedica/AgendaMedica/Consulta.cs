using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaMedica
{
    class Consulta
    {

        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public int CPF { get; set; }

        public string Email { get; set; }

        public int CodigoUsuario { get; set; }

        public static string Especialidades { get; private set; }
        public static int Cardiología { get; private set; }
        public string Confirmar { get; set; }
        public static int Ginecología { get; private set; }
        public static int Odontología { get; private set; }
        public static int Psicología { get; private set; }
        public static int Psiquiatría { get; private set; }

        public void SalvarDadosUsuario()
        {
            Consulta.consultas.Add(this);
        }

        public static List<Consulta> consultas = new List<Consulta>();

        public static List<Consulta> ListaConsultas()
        {
            return Consulta.consultas;

        }
    }
}
