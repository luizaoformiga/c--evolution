using System;

// Aqui vemos como funciona o uso dos objetos privados
namespace privateProgram
{
    class Jogador
    {
        private int energia;
        private string nome;
        public Jogador(string nome, int energia = 100)
        {
            this.nome = nome;
            this.energia = energia; 
        }

        // método para usar o membro privado de uma classe
        public int getEnergia()
        {
            return energia;
        }
        public string getNome()
        {
            return nome;
        }

        // método set para usar 100 como valor padrão e poder retirar valores na hora da compilação
        public void setEnergia(int e)
        {
            // one
            if(e < 0)
            {
                if(energia + e < 0) 
                {
                   energia = 0;
                }   
                
                else 
                {
                  energia += e;
                }
            } 
            
            // two
            else if (e > 0)
            {
                if (energia + e > 100)
                {
                   energia = 100;
                }
            } 

            // three
            else 
            {
                energia += e;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Jogador playerOne = new Jogador("Luiz");

            // usando o método set
            playerOne.setEnergia(-90);

            // pra usarmos de maneira correta os valores do objeto, temos que indicar 
            //o método que foi criado ao invés do obejto em sí
            Console.WriteLine("Nome do jogador: {0}", playerOne.getNome());
            Console.WriteLine("Energia: {0}", playerOne.getEnergia());
        }
    }
}

// nesse código, o menor valor vai ser 0 e o maior vai ser 100 de energia 
