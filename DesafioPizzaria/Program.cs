using System;

namespace DesafioPizzaria {
    class Program {
        static void Main (string[] args) {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine ("-----MUY SABOR!-----");
            Console.ResetColor ();

            int resposta = 0;
            int resposta2 = 0; 

            do {
                Console.WriteLine ("Selecione uma opção");
                Console.WriteLine ("1 - Cadastrar Novo Usuário");
                Console.WriteLine ("2 - Efetuar Login");
                Console.WriteLine ("3 - Listar Usuários");
                Console.WriteLine ("9 - Sair");
                resposta = int.Parse (Console.ReadLine ());

                switch (resposta) {
                    case 1:
                        //Cadastrar usuário
                        Usuario.Inserir ();
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine ("Cadastro Concluído");
                        Console.ResetColor ();
                        System.Console.WriteLine ("Aperte enter para voltar para o menu");
                        Console.ReadLine ();
                        break;

                    case 2:
                        //Login
                        Usuario.EfetuarLogin ();
                        do {
                            
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine ("-----Menu de Produtos-----");
                            Console.ResetColor ();
                            Console.WriteLine ("Selecione uma opção:");
                            Console.WriteLine ("1 - Cadastro do Produto");
                            Console.WriteLine ("2 - Listar os Produtos");
                            Console.WriteLine ("3 - Busca por ID");
                            Console.WriteLine ("0 - Voltar ao menu principal");
                            resposta2 = int.Parse (Console.ReadLine ());

                            switch (resposta2) {

                                case 1:
                                    //Cadastrar um produto
                                    Produto.Cadastro ();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    System.Console.WriteLine ("Cadastro Concluído");
                                    Console.ResetColor ();
                                    System.Console.WriteLine ("Aperte enter para voltar para o menu");
                                    Console.ReadLine ();
                                    break;

                                case 2:
                                    //Exibir os produtos cadastrados
                                    Produto.Listar ();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    System.Console.WriteLine ("Listagem Concluída");
                                    Console.ResetColor ();
                                    System.Console.WriteLine ("Aperte enter para voltar para o menu");
                                    Console.ReadLine ();
                                    break;

                                case 3:
                                    //Buscar uma coisa que eu ainda não entendi 
                                    Produto.ProcurarId();
                                    System.Console.WriteLine ("Busca Concluída");
                                    Console.ResetColor ();
                                    System.Console.WriteLine ("Aperte enter para voltar para o menu");
                                    Console.ReadLine ();

                                    break;

                                case 0:

                                    break;

                                default:
                                    Console.WriteLine ("Valor Inválido!");
                                    break;
                            }

                        } while (resposta2 != 0);
                        break;

                    case 3:
                        //Listar usuário
                        Usuario.ListarUsuario ();
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine ("Listagem Concluída");
                        Console.ResetColor ();
                        System.Console.WriteLine ("Aperte enter para voltar para o menu");
                        Console.ReadLine ();

                        break;

                    case 9:
                        //sair
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine ("Valor Inválido!");
                        Console.ResetColor ();

                        break;
                }

            } while (resposta != 9);
        }
    }
}