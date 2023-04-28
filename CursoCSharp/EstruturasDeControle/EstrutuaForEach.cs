using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstrutuaForEach {

        public static void Executar() {
            var palavra = "Opa!";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bea", "Carlos" };

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
