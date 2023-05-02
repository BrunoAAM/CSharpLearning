using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class CalculadoraEstatica {

        //Metodo de instância
        public int Somar(int a, int b) {
            return a + b;
        }
        //Metodo de Classe ou método estático
        public static int Multiplicar(int a, int b) {
            return a * b;
        }
    }

    internal class MetodosEstaticos {

        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}",resultado);

            CalculadoraEstatica calculadoraEstatica = new CalculadoraEstatica();
            Console.WriteLine(calculadoraEstatica.Somar(2,5));
        }
    }
}
