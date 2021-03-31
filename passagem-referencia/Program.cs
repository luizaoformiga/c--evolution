using System;

namespace passagem_referencia
{
    class Program
    {
        // usamos passagem por referencia atraves do metodo ref 
        static void Main()
        {
            int num = 10;
            Dobrar(ref num);

            Console.WriteLine(num);
        }
        
        static void Dobrar(ref int valor)
        {
           valor *= 2;
        }
    }
}
