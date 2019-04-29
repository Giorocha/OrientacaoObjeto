using System;
using PastelStore.MVC.Utils;
using PastelStore.MVC.ViewController;
using PastelStore.MVC.ViewModel;

namespace PastelStore.MVC {
    class Program {
        static void Main (string[] args) {

            int opcaoDeslogado = 0;

            do {
                //Menu Deslogado
                MenuUtil.MenuDeslogado ();
                opcaoDeslogado = int.Parse (Console.ReadLine ());

                switch (opcaoDeslogado)
                {
                    case 1:
                    //Cadastrar usuário
                    UsuarioViewController.CadatrarUsuario();
                        break;
                    
                    case 2:
                    //Efetuar Login
                    UsuarioViewModel usuarioRetornado = UsuarioViewController.EfetuarLogin();
                        break;

                    case 3:
                    //Listar usuários Cadastrados
                    UsuarioViewController.ListarUsuario();
                        break;
                    
                    case 0:
                    //Sair
                        break;
                    
                    default:
                    Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (opcaoDeslogado != 0);
        }
    }
}