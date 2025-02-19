//Hola señores y señoras, damas e caballeros.
using System;
using System.Collections.Specialized;

namespace Aula01
{
    public class Program
    {
        static void Main(string[] args)
        {
           CalcularMedia();
        }


        public static void ConcatenarPalavras()
        {
            Console.WriteLine("digite seu nome");
            string nome = Console.ReadLine();

            string frase1 = $"olá {nome}, hoje é {DateTime.Now}";
            Console. WriteLine(frase1);
            Console.WriteLine(" ");

            Console.WriteLine("quanto custa um dolar em reais ");
            decimal valordolarreais = decimal.Parse(Console.ReadLine());
            string frase2 = string.Format("hoje é dia {0:ddd}, o dolar esta custando{1:c2}", DateTime.Now, valordolarreais);
            Console.WriteLine(frase2);

            Console.WriteLine(" ");
            string cabecalho = string.Format("{0:dddd},{0:dd}, {0:MMM} de {0:YYYY} ", DateTime.Now);
            Console.WriteLine (cabecalho.ToUpper());
        }


        public static void VerificarAulaEtec()
        {
            Console.WriteLine("digite a data;");
            DateTime data = DateTime.Parse(Console.ReadLine());
            if(data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("fianl de samana!! hoje não tem aula!! revisarei execicios.");
            }
        
            else
            {
                Console.WriteLine("dia da semana! bora pra etec!");
            }
        }
        
        public static void CalcularMedia()
        {
            Console.WriteLine("digite a primeira nota:");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("digite a segunda nota:");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A média é{media}");

            if(media>= 7)
               Console.WriteLine("aprovado}");
            else if (media < 7 && media >= 4) 
               Console.WriteLine("recuperação");
            else
                Console.WriteLine("reprovado");

        }
    }

}