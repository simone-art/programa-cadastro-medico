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
                Console.WriteLine("3- Escolha outra especialidade");
                Console.WriteLine("4- Escolha día e hora da consulta");
                Console.WriteLine("5- Sair");
                var opcoes = Convert.ToInt16(Console.ReadLine());
                if (opcoes == 5) break;
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
                        usuario.Email = Console.ReadLine();
                        Console.WriteLine("Ingrese o código que voçê recebeu via email");
                        usuario.CodigoUsuario = Convert.ToInt16(Console.ReadLine());
                        var retorno = usuario.SalvarDadosUsuario();
                        MensagemConfirmacao(retorno);
                        Console.ReadLine();
                        break;

                    case 2:
                        EscolherEspecialidade();
                        break;

                    case 3:
                        Console.WriteLine("* Oftalmología Digite 2");
                        Console.ReadLine();

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


        static void EscolherEspecialidade()

        {

            while (true)
            {
                Console.WriteLine("=====Especialidades=========");
                Console.WriteLine("* Escolha a sua opção: ");
                Console.WriteLine("============================");
                Console.WriteLine("============================");
                Console.WriteLine("* \ta Cardiología  Digite a");
                Console.WriteLine("* \tb Ginecología  Digite b");
                Console.WriteLine("* \tc Oftalmología Digite c");
                Console.WriteLine("* \td Psicología   Digite d");
                Console.WriteLine("* \te Psiquiatría  Digite e");
                Console.WriteLine("============================");
                Console.WriteLine("============================");
                Console.Write("A sua opção é? ");
                Console.ReadLine();
                //var opcoesEspecialidades = Console.ReadLine());
                //if (opcoesEspecialidades == 5) break;
                //Console.Clear();

                switch (Console.ReadLine())

                {
                    case "a":
                        Console.WriteLine("Voçé está confirmado para Cardiología");
                        Console.ReadLine();
                        break;

                    case "b":
                        Console.WriteLine("Voçé está confirmado para Ginecología");
                        Console.ReadLine();
                        break;

                    case "c":
                        Console.WriteLine("Voçé está confirmado para Oftalmología");
                        Console.ReadLine();
                        break;

                    case "d":
                        Console.WriteLine("Voçé está confirmado para Psicología");
                        Console.ReadLine();
                        break;

                    case "e":
                        Console.WriteLine("Voçé está confirmado para Psiquiatría");
                        Console.ReadLine();
                        break;


                }

                Console.Clear();
            }
        }

    }
}