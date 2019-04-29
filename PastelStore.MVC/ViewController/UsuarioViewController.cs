using System;
using System.Collections.Generic;
using PastelStore.MVC.Repositorio;
using PastelStore.MVC.Utils;
using PastelStore.MVC.ViewModel;

namespace PastelStore.MVC.ViewController {
    public class UsuarioViewController {
        //Instanciar o repositorio
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();

        public static void CadatrarUsuario () {

            string nome, email, senha, confirmaSenha;

            do {
                Console.WriteLine ("Digite o nome do usuário: ");
                nome = Console.ReadLine ();

                if (string.IsNullOrEmpty (nome)) {
                    Console.WriteLine ("Nome Inválido");
                }
            } while (string.IsNullOrEmpty (nome)); //repetição

            do {
                Console.WriteLine ("Digite o seu E-Mail: ");
                email = Console.ReadLine ();

                if (!ValidacoesUtil.validadorDeEmail (email)) {
                    Console.WriteLine ("Email ou Senha inválido");
                }

            } while (!ValidacoesUtil.validadorDeEmail (email));

            do {
                Console.WriteLine ("Digite a senha:");
                senha = Console.ReadLine ();

                Console.WriteLine ("Confirme a senha");
                confirmaSenha = Console.ReadLine ();

                if (!ValidacoesUtil.ValidadorDeSenha (senha, confirmaSenha)) {
                    Console.WriteLine ("Senha Inválida!");
                }

            } while (!ValidacoesUtil.ValidadorDeSenha (senha, confirmaSenha));

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;

            usuarioRepositorio.Inserir (usuarioViewModel);

            Console.WriteLine ("Usuário Cadastrado com sucesso");
            Console.ReadLine ();
        } //fim cadastro de usuário

        public static void ListarUsuario () {
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar ();

            foreach (var item in listaDeUsuarios) {
                Console.WriteLine ($"Id: {item.Id}");
                Console.WriteLine ($"Nome: {item.Nome}");
                Console.WriteLine ($"E-Mail: {item.Email}");
                Console.WriteLine ($"Senha: {item.Senha}");
                Console.WriteLine ($"Data de criação: {item.DataCriacao}");
                Console.WriteLine ("--------------------------------------------");
            }
            Console.ReadLine ();
        } // Fim Listar Usurio

        public static UsuarioViewModel EfetuarLogin () {
            string email, senha;
            do {
                Console.WriteLine ("Digite o E-Mail: ");
                email = Console.ReadLine ();

                if (ValidacoesUtil.validadorDeEmail (email)) {
                    Console.WriteLine ("Email Inválido");
                }
            } while (!ValidacoesUtil.validadorDeEmail (email));

            Console.WriteLine ("Digite sua Senha: ");
            senha = Console.ReadLine ();

            UsuarioViewModel usuarioRetornado = usuarioRepositorio.BuscarUsuario (email, senha);

            if (usuarioRetornado != null) {
                return usuarioRetornado;
            }else{
                Console.WriteLine($"Usuário ou Senha Inválida");
                return null;
            }

        } //Fim efetuar login
    }
}