using System;

public class Jogador
{
   public int energia = 10;
   public bool vivo = true;
   
}

class Program
{
    static void Main()
    {
        Jogador jogador_one = new Jogador();
        Jogador jogador_two = new Jogador();
        Jogador jogador_three = new Jogador();
        
        // mudando o valor padrão
        jogador_one.energia = 60; 

        Console.WriteLine("Energia do jogador 1: {0}", jogador_one.energia);
         
    }
}


// Como vemos acima, estamos criando classes publicas para serem usadas em outras classes, na verdade estamos mostrando exemplos de classes e objetos

// No c#, usar uma outra classe com os valores dela pode reprensetar um tipo de método chamado constructor