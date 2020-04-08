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

        //public int CodigoUsuario { get; set; }

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
