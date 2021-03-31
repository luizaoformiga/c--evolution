using System;

class Program
{
    static void Main()
    {
        int dividendoOne, divisorOne, quocOne, restOne;
        dividendoOne = 10;
        divisorOne = 5;
        quocOne = divide(dividendoOne, divisorOne, out restOne);
        
        Console.WriteLine("{0} / {1} : quociente = {2} e o resto = {3}", dividendoOne, divisorOne, quocOne, restOne);
    }

    // método out serve para retornar e passar dois argumentos dentro de um static
    static int divide(int dividendo, int divisor, out int resto)
    {
       int quociente = dividendo / divisor;
       resto = dividendo % divisor;
       return quociente;    
    }

}

