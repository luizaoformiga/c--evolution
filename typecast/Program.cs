using System;

namespace TypecastProgram
{
    class Program
    {
        static void Main()
        {
           float n1 = 10.5f;
           int n2 = (int)n1; // typecast

           Console.WriteLine(n2);
        }
    }
}

// aqui vemos um breve exemplo de como converter um valor float para int com o typecast