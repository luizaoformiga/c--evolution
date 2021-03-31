using System;

class Frase
{
    public Frase()
    {
        Console.WriteLine("Ola mundo");
    }
}

class FraseTwo:Frase
{
    public FraseTwo()
    {
        Console.WriteLine("Ola mundo dois");
    }     
}

class Program:FraseTwo
{
    static void Main()
    {
        FraseTwo totalFrases = new FraseTwo();
    }
}