using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos {

        public static void Executar() {

            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é de {0}", totalComDesconto);

            //IMC
            double peso = 82.2;
            var altura = 1.85;
            double imc = peso/Math.Pow(altura, 2);
            Console.WriteLine($"IMC é de {imc}");

            // Número Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par%2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar%2);




        }
    }
}
