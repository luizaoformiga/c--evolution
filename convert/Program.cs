using System;

namespace metodos2
{
    class Program
    {
        static void Main()
        { 
            int v1, v2, responseSoma;

            //convertendo string para numeros inteiros 
            Console.Write("Digite um valor: ");
            v1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());

            responseSoma = soma(v1, v2);
            Console.WriteLine("A soma ente {0} e {1} é igual a {2}", v1, v2, responseSoma);

        }
        
        static int soma(int a, int b)
        {
            int response = a + b;
            return response;
        }
    }
}
