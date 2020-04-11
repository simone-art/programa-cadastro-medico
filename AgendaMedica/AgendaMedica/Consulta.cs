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

        public int Especialidades { get; set; }
        public int Cardiología { get; set; }
       
        public string Confirmar { get; set; }
        public int IdConsulta { get; set; }

        public int SalvarDadosUsuario()
        {
            Random random = new Random();
            this.IdConsulta = random.Next();
            Consulta.consultas.Add(this);

            return this.CodigoUsuario;
        }

        public static List<Consulta> consultas = new List<Consulta>();

        public static List<Consulta> ListaConsultas()
        {
            return Consulta.consultas;

        }
    }
}
