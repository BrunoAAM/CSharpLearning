using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class SubCelebridade {

        //Todos
        public string InfoPublica = "Tenho uma instagram!";

        //Herança
        protected string CorDoOlho = "Verde";

        //Mesmo projeto (assembly)
        internal ulong NumeroCelular = 40028922;

        //Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //Mesma classe ou herança no mesmo projeto
        private protected string SegredoFamilia = "Bla Bla";

        //Priva é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }

    }
}
