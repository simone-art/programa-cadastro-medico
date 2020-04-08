using System;

namespace AgendaMedica
{
    class Program
    {
        public static int CodigoUsuario { get; private set; }
        public static object Especialidades { get; private set; }
        public static object Cardiología { get; private set; }
        public static object Ginecología { get; private set; }
        public static object Confirmar { get; private set; }

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
                        Console.ReadLine();
                        Console.WriteLine("Cadastre o seu sobrenome");
                        Console.ReadLine();
                        Console.WriteLine("Cadastre o seu CPF");
                        Console.ReadLine();
                        Console.WriteLine("Cadastre o seu email");
                        Console.ReadLine();
                        Console.WriteLine("Ingrese o código que voçê recebeu via email");
                        Console.ReadLine();
                        MensagemConfirmacao();
                        break;

                    case 2:
                       
                        //Console.WriteLine("* Cardiología  Digite 1");
                        //Console.ReadLine();
                        //Console.Clear();
                        //Console.WriteLine("* Ginecología Digite 2");
                        //Console.ReadLine();
                        //Console.Clear();
                        //Console.WriteLine("* Odontología Digite 3");
                        //Console.ReadLine();
                        //Console.Clear();
                        //Console.WriteLine("* Psicología Digite 4");
                        //Console.ReadLine();
                        //Console.Clear();
                        //Console.WriteLine("* Psiquiatría Digite 5");
                        //Console.ReadLine();
                        //Console.Clear();
                        EscolherEspecialidade();
                        break;

                }
                Console.Clear();


            }

            static void MensagemConfirmacao()
            {
                if (CodigoUsuario == 1234)
                {
                    Console.WriteLine("Cadastro foi feito com sucesso!");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Cadastro foi feito com sucesso!");
                    Console.ReadLine();
                }

            }
        }

        private static void EscolherEspecialidade()

        {

            Console.WriteLine("* Cardiología  Digite 1");
            Console.ReadLine();
            Console.Clear();

            if (Program.Especialidades == Cardiología)
            {
                Console.WriteLine("Voçê escolheu Cardiología. Digite Confirmar!");
                Console.ReadLine();
                Console.Clear();
            }

            if (Program.Cardiología == Confirmar)
            {
                Console.WriteLine("Confirmada Consulta Cardiología");
                Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("* Ginecología Digite 2");
            Console.ReadLine();
            Console.Clear();

            if (Program.Especialidades == Ginecología)
            {
                Console.WriteLine("Voçê escolheu Ginecología. Digite Confirmar!");
                Console.ReadLine();



            }

            if (Program.Ginecología == Confirmar)
            {
                Console.WriteLine("Confirmada Escolha Ginecología");
                Console.ReadLine();
                Console.Clear();
            }

           
        }
    }   }
