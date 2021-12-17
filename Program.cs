using System;

namespace Media_Decimal_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd, cont = 0;
            decimal soma = 0, media, numDigitado;
            


            Console.Write("Digite a quantidade de números: ");
            qtd = Convert.ToInt32(Console.ReadLine());

            decimal maiorNum = 0;
            decimal menorNum = 0;

            while (cont < qtd)
            {

                cont += 1;
                Console.Write($"Número  {cont}:  ");
                numDigitado = Convert.ToDecimal(Console.ReadLine());
                soma = soma + numDigitado;
                

                if (cont == 1){
                    maiorNum = numDigitado;
                    menorNum = numDigitado;
                }
                else {

                }
                
                if (numDigitado > maiorNum)
                {
                     maiorNum = numDigitado;
                }
                if (numDigitado < menorNum)
                {
                     menorNum = numDigitado;
                }
            }

            media = soma / qtd;

            Console.WriteLine($"\nSoma :  {soma:N2}");
            Console.WriteLine($"Média:  {media:N2}");
            Console.WriteLine($"Maior:  {maiorNum:N2}");
            Console.WriteLine($"Menor:  {menorNum:N2}");

        }
    }
}
