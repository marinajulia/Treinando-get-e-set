using System;

namespace Exercício6 {
    public class Locadora {
        private string titulo;
        private int anoLancado;

        public string Titulo {
            get { return titulo; }
            set { titulo = value; }
        }

        public int AnoLancado {
            get { return anoLancado; }
            set { anoLancado = value; }
        }
    }
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com o título do filme:");
            string titulofilme = Console.ReadLine();

            Console.WriteLine("Entre com o ano do filme:");
            int ano = Convert.ToInt32(Console.ReadLine());

            Locadora filme1 = new Locadora();
            filme1.Titulo = titulofilme;
            filme1.AnoLancado = ano;

            Console.WriteLine(filme1.Titulo + " " + filme1.AnoLancado);
            
        }
    }
}
