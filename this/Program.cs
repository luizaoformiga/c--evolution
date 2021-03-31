using System;

// aqui vemos um exemplo do comando this, que específica atribuições de valores para indicar parametros numa determinada classe

namespace This
{
    class Calculos 
    {
        // aqui crio duas class int 
        public int NumberOne;
        public int NumberTwo;

        // em seguida, faço o uso delas para a soma
        public Calculos(int numbParamOne, int numbParamTwo)
        {
            this.NumberOne = numbParamOne;
            this.NumberTwo = numbParamTwo;
        }   
        public int Somar()
        {
            return NumberOne + NumberTwo;
        }
    }

    // essa clase principal fica responsável por compilar o resultado da escolha
    class Program
    {
        static void Main()
        {
            //Calculos calculoOne = new Calculos();

            //Console.WriteLine(calculoOne.Somar());
        }
    }
}
