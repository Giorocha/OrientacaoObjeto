using System;

namespace Ex1 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Bem vindo - Giovanesses Bank");
            

            ContaCorrente conta1 = new ContaCorrente (); //Instanciar = criar
            conta1.titular = "Cesar";
            conta1.agencia = 132;
            conta1.numeroConta = 999;
            conta1.Depositar (10000);

            ContaCorrente conta2 = new ContaCorrente ();
            conta2.titular = "Giovanna";
            conta2.agencia = 388;
            conta2.numeroConta = 910;
            conta2.Depositar (2000);

            Console.WriteLine ($"----Primeira conta----");
            Console.WriteLine ($"Titular: {conta1.titular}");
            Console.WriteLine ($"Agência: {conta1.agencia}");
            Console.WriteLine ($"Numero da conta: {conta1.numeroConta}");
            Console.WriteLine ($"Saldo: R${conta1.ExibirSaldo()}");
            Console.WriteLine ($"----------------------");

            Console.WriteLine ($"----Segunda conta----");
            Console.WriteLine ($"Titular: {conta2.titular}");
            Console.WriteLine ($"Agência: {conta2.agencia}");
            Console.WriteLine ($"Numero da conta: {conta2.numeroConta}");
            Console.WriteLine ($"Saldo: R${conta2.ExibirSaldo()}");
            Console.WriteLine ($"----------------------");

            //bool valorRetornado = conta1.Sacar(3500);
            // if (valorRetornado){
            //    Console.WriteLine("Parabéms você conseguiu!");
            // }else{
            //    Console.WriteLine("Você não tem dinheiro na conta!");
            // }
            //System.Console.WriteLine($"Saldo depois do saque: R${conta1.ExibirSaldo()}");

            conta2.Transferir(333, conta1);
            Console.WriteLine($"Saldo conta 1: {conta1.ExibirSaldo()}");
            Console.WriteLine($"Saldo conta 2: {conta2.ExibirSaldo()}");
        }
    }
}