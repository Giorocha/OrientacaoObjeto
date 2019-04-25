using System;

namespace DesafioPizzaria {
    public class Produto {
        static Produto[] ArrayDeProdutos = new Produto[1000];
        static int contador = 0;
        public int ID { get; set; }

        public string Nome { set; get; }

        public double Preço { get; set; }

        public string Descriçao { get; set; }

        public string Categoria { get; set; }

        public DateTime DataCriacao { get; set; }

        public Produto (string nome, string descricao, string categoria, double preço) {
            this.Nome = nome;
            this.Descriçao = descricao;
            this.Categoria = categoria;
            this.Preço = preço;
            this.ID = contador + 1;
            this.DataCriacao = DateTime.Now;
            contador++;
        }

        public static void Cadastro () {
            string nome;
            string descricao;
            double preço;
            string categoria;

            Console.WriteLine ("Digite o nome do produto:");
            nome = Console.ReadLine ();

            Console.WriteLine ("Descreva seu produto:");
            descricao = Console.ReadLine ();

            Console.WriteLine ("Determine o preço:");
            preço = double.Parse (Console.ReadLine ());

            Console.WriteLine ("Determine uma categotia:");
            categoria = Console.ReadLine ();

            Produto pdt = new Produto (nome, descricao, categoria, preço);

            ArrayDeProdutos[contador] = pdt;

        }
        public static void Listar () {
            foreach (var item in ArrayDeProdutos) {
                if (item == null) {
                    break;
                }
                if (item != null) {
                    Console.WriteLine ($"ID: {item.ID} ");
                    Console.WriteLine ($"Nome: {item.Nome}");
                    Console.WriteLine ($"Descrição: {item.Descriçao}");
                    Console.WriteLine ($"Preço: {item.Preço}");
                    Console.WriteLine ($"Categoria: {item.Categoria}");

                }
            }

        }
        public static void ProcurarId () {
            System.Console.WriteLine ("Digite o ID do seu produto");
            int ID = int.Parse (Console.ReadLine ());

            foreach (var item in ArrayDeProdutos) {
                if (item == null) {
                    break;
                }

                if (ID == item.ID) {
                    System.Console.WriteLine ($"ID: {item.ID}");
                    System.Console.WriteLine ($"Nome: {item.Nome}");
                    System.Console.WriteLine ($"Descrição: {item.Descriçao}");
                    System.Console.WriteLine ($"Categotia: {item.Categoria}");
                    System.Console.WriteLine ($"Preço: {item.Preço}");
                }
            }
        }
    }
}