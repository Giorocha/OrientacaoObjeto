using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
           int contadorAlunos = 0;
         int contadorSalas = 0;

            Aunos[] alunos = new Alunos[2];
            Sala[] salas = new Sala[2];

            Console.WriteLine("-----Bem vindo ao SENAIzinho!-----");

            do {
                Console.WriteLine("Selecione uma opção abaixo");
                Console.WriteLine("");
                Console.WriteLine("1- Cadastrar Aluno");
                Console.WriteLine("2- Cadastrar Sala");
                Console.WriteLine("3- Alocar Aluno");
                Console.WriteLine("4- Remover Aluno");
                Console.WriteLine("5- Verificar Salas");
                Console.WriteLine("6- Verificar Alunos");
                Console.WriteLine("0- Sair");
                Console.WriteLine("");
                Console.WriteLine("O que deseja?");

                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo)
                {
                    case 1:

                    Aluno a = new Aluno();
                    Console.WriteLine("Nome do indivíduo:");
                    a.nome = Console.ReadLine(); 
                    Console.WriteLine("Data de aniversário:");
                    a.dataNascimento = Console.ReadLine();
                    Console.WriteLine("Curso desejado:");
                    a.curso = Console.ReadLine();
                    Console.WriteLine("Número da sala:");
                    a.numeroSala = Console.ReadLine();   
                    alunos[contadorAlunos] = a;
                    contadorAlunos++;
                    break;

                    case 2:
                       Sala s = new Sala ();
                       Console.Write ("Digite a capaciadede máxima da sala: ");
                       s.capacidadeTotal = int.Parse (Console.ReadLine ());
                       Console.Write ("Digite o número da sala: ");
                       s.numeroSala = int.Parse (Console.ReadLine ());
                       salas[contadorSalas] = s;
                       contadorSalas++;

                    break;

                    case 3:

                    break;

                }

            }while(!querSair);

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