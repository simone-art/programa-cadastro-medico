using System;

namespace AgendaMedica
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("=================================================================");
            Console.WriteLine("Bem-vindo a nossa plataforma de agendamento de consultas online");
            Console.WriteLine("=================================================================");
            Console.WriteLine("Escolha as seguintes opções");
            Console.WriteLine("=================================================================");

            while (true)
            {
                Console.WriteLine("1- Cadastrar Dados Pessoais");
                Console.WriteLine("2- Escolha a especialidade");
                Console.WriteLine("3- Escolha día e hora da consulta");
                Console.WriteLine("4- Sair");
                var opcoes = Convert.ToInt16(Console.ReadLine());
                if (opcoes == 4) break;
                Console.Clear();

                switch (opcoes)
                {
                    case 1:
                        Console.WriteLine("Cadastre o seu nome");
                        var usuario = new Consulta();
                        usuario.Nome = Console.ReadLine();
                        Console.WriteLine("Cadastre o seu sobrenome");
                        usuario.Sobrenome = Console.ReadLine();
                        Console.WriteLine("Cadastre o seu CPF");
                        usuario.CPF = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cadastre o seu email");
                        usuario.Email= Console.ReadLine();
                        Console.WriteLine("Ingrese o código que voçê recebeu via email");
                        usuario.CodigoUsuario = Convert.ToInt16(Console.ReadLine());
                        var returno = usuario.SalvarDadosUsuario();
                        MensagemConfirmacao(returno);
                        break;

                    case 2:
                        EscolherEspecialidade();
                        break;

                }
                Console.Clear();


            }

            static void MensagemConfirmacao(int CodigoUsuarioMedico)
            {
                if (CodigoUsuarioMedico == 1234)
                {
                    Console.WriteLine("Cadastro  foi feito com sucesso!");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Cadastro não foi feito com sucesso!");
                    Console.ReadLine();
                }

            }
        }

        public static void EscolherEspecialidade()

        {

            Console.WriteLine("* Cardiología  Digite 1");
            Console.ReadLine();
            Console.Clear();

            //var consulta = new Consulta();
            //consulta.Cardiología = 1;
            //Console.WriteLine("*Cardiología");

            /*if (consulta.Cardiología == 1)
            {
                Console.WriteLine("Voçê escolheu cardiología. Digite 1 para confirmar");
            }*/
            
            



            
        }
    }
}