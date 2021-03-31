using System;

// params muita das vezes servem para que não possamos precisar colocar valores no parametro da função, como pode ver no exemplo abaixo, pegamos o params e criamos um array, onde os numeros colocados na função que fizemos são lidos atraves do comando for mas precisamente pela variavel i

namespace arguments
{
    class Program
    {
        static void Main()
        {
            soma(2, 3, 4);
        }

        static void soma(params int[]numbers)
        {
            int response = 0;

            switch (numbers.Length)
            {
                case 1:
                    if(numbers.Length < 1) 
                    {
                       Console.WriteLine("não existem valores a serem somados");
                    }
                break;

                case 2: 
                    if (numbers.Length < 2)
                    {
                       Console.WriteLine("valores insuficientes para soma: {0}", numbers[0]);   
                    }
                break;

                case 3:
                    for (int i = 0; i < numbers.Length; i ++)
                    {
                       response += numbers[i];
                    }    
                break;

                default:
                break;
            }
            
            Console.WriteLine("Resultado da soma:  {0}", response);
        }
    }
}
