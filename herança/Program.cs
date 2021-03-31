using System;

//classe base
class Veiculo 
{
    public int rodas;
    public int velMax;
    
    public bool ligado;
    
    public void ligar()
    {
        ligado = true;

    }
    
    public void desligar()
    {
        ligado = false;
        
    }

    public string getLigado()
    {
        if(ligado)
        {
            return "SIM";
        }
        else 
        {
            return "NÂO";
        }
    }
}

// Aqui estamos herdando a classe herdada pela a classe derivada
class Carro:Veiculo
{
   public string nome;
   public string cor;

    public Carro(string v)
    {
    }

    public Carro()
   {
       desligar();
       rodas = 4;
       velMax = 120;
       nome = "Corolla";
       cor = "Laranja";
       
   }
}

// classe responsável por compilar o código
class Herança
{
    static void Main()
    {
        Carro c1 = new Carro();

        Console.WriteLine("cor: {0}", c1.cor);
        Console.WriteLine("nome: {0}", c1.nome);
        Console.WriteLine("Rodas: {0}", c1.rodas);
        Console.WriteLine("Vel.Máxima: {0}", c1.velMax);
        Console.WriteLine("Ligado: {0}", c1.getLigado());
    }
}