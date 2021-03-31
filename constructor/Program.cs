using System;

public class Player
{
    public string nome;

    public Player(string nes)
    {
        nome = nes;
    }
} 
class Program
{
    static void Main()
    {
        string name_player;
        
        Console.Write("Escreva o nome do jogador: ");
        name_player = Console.ReadLine();

        Player player_one = new Player(name_player);

        Console.WriteLine("Nome do jogador 1: {0}", player_one.nome);
    }
}

// nessa aula vemos uns conceitos básicos de constructor ou em portugues construtores