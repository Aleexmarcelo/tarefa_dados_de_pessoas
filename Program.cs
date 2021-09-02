using System;
using System.Globalization;

namespace TarefaPessoas
{
    class Program
    {
        static void Main(string[] args)
        {   //Instaciar a variavel
            Pessoas x;
            Pessoas y;

            //Instanciar a Variável
            x = new Pessoas();
            y = new Pessoas();

            // Informação para o usuário digitar o nome e idade
            Console.WriteLine("Diga seu nome");
            x.name = (Console.ReadLine());
            Console.WriteLine("Ok, seu nome é:", x);

            Console.WriteLine("Agora me diga sua idade");
            x.idade = int.Parse(Console.ReadLine());

            // Informação para o usuário digitar o nome e idade
            Console.WriteLine("Diga seu nome");
            y.name = Console.ReadLine();
            Console.WriteLine("Ok, seu nome é:", y);
            Console.WriteLine("Agora me diga sua idade");
            y.idade = int.Parse(Console.ReadLine());

            //Comparação para saber quem é o mais velho
            if
                (x.idade > y.idade)

                Console.WriteLine("O mais velho é Mario");

            else
                Console.WriteLine("O mais velho é Luigi");

        }
    }
}
