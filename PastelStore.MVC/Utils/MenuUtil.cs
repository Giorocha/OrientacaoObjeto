using System;

namespace PastelStore.MVC.Utils {
    public class MenuUtil {
        /// <summary>
        /// Mostra as opções do usuário deslogado
        /// </summary>
        public static void MenuDeslogado () {
            Console.WriteLine ("--------------------------------------------");
            Console.WriteLine ("---------Restaurante PasltelStore-----------");
            Console.WriteLine ("-------------      Conta      --------------");
            Console.WriteLine ("--------------------------------------------");
            Console.WriteLine ("           (1) Cadastrar Usuário            ");
            Console.WriteLine ("           (2) Efetuar Login                ");
            Console.WriteLine ("           (3) Listar                       ");
            Console.WriteLine ("--------------------------------------------");
            Console.WriteLine ("           (0) Sair                         ");
            Console.WriteLine ("--------------------------------------------");
            Console.WriteLine ("           Escolha uma opção                ");

        }

    }
}