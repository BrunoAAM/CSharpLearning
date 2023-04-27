﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine($"Nota truncada: {notaTruncada}");

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse( idadeString );
            Console.WriteLine($"Idade inserida, {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);


            Console.Write("Digite um numero ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse( palavra, out numero);
            Console.WriteLine($"O número é  {numero}");


            Console.Write("Digite o segundo numero ");
           int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"O segundo número é {numero2}");
        }

    }
}
