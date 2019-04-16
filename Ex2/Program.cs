using System;

namespace Ex2 {
    class Program {
        static void Main (string[] args) {
            bool querSair = false;
            int contadorAluno = 0;
            int contadorSala = 0;

            Aluno[] alunos = new Aluno[4];
            Sala[] salas = new Sala[1];

            do {
                System.Console.WriteLine ("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine (" ==== Bem vindo(a) ao Senaizin ==== ");
                System.Console.WriteLine ("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine ("        ====== Menu ======= ");
                System.Console.WriteLine ("");
                Console.ResetColor ();

                Console.WriteLine ("Selecione uma opção abaixo");
                Console.WriteLine ("");
                Console.WriteLine ("1- Cadastrar Aluno");
                Console.WriteLine ("2- Cadastrar Sala");
                Console.WriteLine ("3- Alocar Aluno");
                Console.WriteLine ("4- Remover Aluno");
                Console.WriteLine ("5- Verificar Salas");
                Console.WriteLine ("6- Verificar Alunos");
                Console.WriteLine ("0- Sair");
                Console.WriteLine ("");

                Console.WriteLine ("O que deseja?");

                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) {
                    case 1:
                        if (contadorAluno < 4) {

                            Aluno a = new Aluno ();
                            Console.WriteLine ("Nome do indivíduo:");
                            a.Nome = Console.ReadLine ();
                            Console.WriteLine ("Data de aniversário:");
                            a.DataNascimento = DateTime.Parse (Console.ReadLine ());
                            Console.WriteLine ("Curso desejado:");
                            a.Curso = Console.ReadLine ();

                            Console.WriteLine ("Número da sala:");
                            a.NumeroSala = int.Parse (Console.ReadLine ());
                            alunos[contadorAluno] = a;
                            contadorAluno++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine ("Cadastro Concluído");
                            Console.ResetColor ();
                            System.Console.WriteLine ("Aperte enter para voltar para o menu");
                            Console.ReadLine ();
                        }

                        break;

                    case 2:
                        if (contadorSala < 1) {

                            Sala s = new Sala ();
                            Console.Write ("Digite a capaciadede máxima da sala: ");
                            s.CapacidadeTotal = int.Parse (Console.ReadLine ());
                            Console.Write ("Digite o número da sala: ");
                            s.NumeroSala = int.Parse (Console.ReadLine ());

                            s.CapacidadeAtual = s.CapacidadeTotal;

                            s.Alunos = new string[s.CapacidadeTotal];

                            salas[contadorSala] = s;
                            contadorSala++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine ("Cadastro Concluído");
                            Console.ResetColor ();
                            System.Console.WriteLine ("Aperte enter para voltar para o menu");
                            Console.ReadLine ();

                        }

                        break;

                    case 3:
                        Console.WriteLine ("Digite o nome do alunos que você deseja alocar: ");
                        string nome = Console.ReadLine ();

                        Console.WriteLine("Digite o número da sala: ");
                        int nSala = int.Parse(Console.ReadLine ());

                        foreach (var item in salas) {
                            
                        }

                        break;

                    case 4:
                        Console.WriteLine ("Diigite o nome do aluno você deseja remover:");
                        Console.ReadLine ();
                        break;

                    case 5:
                        //Listar salas
                        foreach (var item in salas) {
                            if (item != null) {
                                Console.WriteLine ("----------------------");
                                Console.WriteLine ($"Número da sala: {item.NumeroSala}");
                                Console.WriteLine ($"Vagas Disponíveis: {item.CapacidadeAtual}");
                                Console.WriteLine ("----------------------");
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine ("Cadastro Concluído");
                        Console.ResetColor ();
                        System.Console.WriteLine ("Aperte enter para voltar para o menu");
                        Console.ReadLine ();
                        break;

                    case 6:
                        foreach (var item in alunos) {
                            if (item != null) {

                                Console.WriteLine ("----------------------");
                                Console.WriteLine ($"Nome do aluno: {item.Nome}");
                                Console.WriteLine ($"Curso: {item.Curso}");
                                Console.WriteLine ("----------------------");
                            }

                        }
                        System.Console.WriteLine ("Aperte enter para voltar para o menu");
                        Console.ReadLine ();
                        break;

                }

            } while (!querSair);

        }
    }
}

//                     case 3:
//                         Console.WriteLine ("Digite o nome do aluno que você deseja mover");
//                         string nomeAluno = Console.ReadLine ();
//                         Console.Write ("Digite o número da sala para qual deseja movê-lo(a): ");
//                         int numeroSala = int.Parse (Console.ReadLine ());
//                         Aluno AlunoParaMover;
//                         for (int i = 0; i < salas.Length; i++) {
//                             if (salas[i] != null) {
//                                 if (alunos[i].nome == nomeAluno && alunos[i] != null) {
//                                     AlunoParaMover = alunos[i];
//                                     if (salas[i].numeroSala == numeroSala) {
//                                         salas[i].AlocarAluno (AlunoParaMover, numeroSala);
//                                     }
//                                 }
//                             } else {
//                                 break;
//                             }
//                         }
//                         break;
//                     case 4:
//                         break;
//                     case 5:
//                         for (int i = 0; i < salas.Length; i++) {
//                             if (salas[i] != null) {
//                                 Console.WriteLine ($"SALA {salas[i].numeroSala}");
//                                 Console.WriteLine ($"Capacidade total da sala: {salas[i].capacidadeTotal}");
//                             }
//                         }
//                         break;
//                     case 6:
//                         for (int i = 0; i < alunos.Length; i++) {
//                             if (alunos[i] != null) {

//                                 Console.WriteLine ($"Nome do aluno {alunos[i].nome}");
//                                 Console.WriteLine ($"Data de nascimento do aluno; {alunos[i].dataNascimento:dd/MM/yyyy}");
//                                 Console.WriteLine ($"Curso do aluno: {alunos[i].Curso}");
//                                 Console.WriteLine ($"Número da sala do aluno: {alunos[i].numeroSala}");
//                             }
//                         }

//                         break;
//                     case 0:
//                         Console.WriteLine ("Você selecionou sair");
//                         noMenu = false;
//                         break;
//                     default:
//                         break;
//                 }
//                 if (noMenu) {
//                     Console.WriteLine ("Pressione ENTER para voltar ao menu principal");
//                     Console.ReadLine ();
//                 } else {
//                     Console.WriteLine ("Pressione ENTER para finalizar o programa");
//                     Console.ReadLine ();
//                 }
//                 Console.Clear ();
//             } while (noMenu);
//         }
//     }
// }