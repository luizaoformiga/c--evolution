using System;
// cadeia de herança e constuctor da classe base

//classe base
class Veiculo 
{
    private int rodas;
    public int velMax;
    public bool ligado;
    // constructor
    public Veiculo(int rodas)
    {
        this.rodas = rodas;
    }
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
       return (ligado ? "SIM" : "NÃO");
    }

    public int getRodas()
    {
       return rodas;  
    }

    public void setRodas(int rodas)
    {
       if(rodas < 0)
       {
           this.rodas = 0;
       }
       else if (rodas > 40) 
       {
           this.rodas = 40;
       }
       else 
       {
           this.rodas = rodas;
       }
    }
}

// Aqui estamos herdando a classe herdada pela a classe derivada
class Carro:Veiculo
{
   public string nome;
   public string cor;
    public Carro(string nome, string cor):base(4)
    {
       desligar();
       velMax = 120;
       this.nome = nome;
       this.cor = cor; 
    }
}

// cadeia de herança
// Aqui eu passo valores em herança para serem usadas na minha classe
class CarroCombate:Carro
{
    public int muniçao;
    public CarroCombate():base("carro de combate", "verde")
    {
       muniçao = 100;
       setRodas(6);

    }
}

// classe responsável por compilar o código
class Herança
{
    static void Main()
    {
        Carro c1 = new Carro("Corolla", "Preto");
        CarroCombate cc1 = new CarroCombate();

        Console.WriteLine("cor:        {0}", c1.cor);
        Console.WriteLine("nome:       {0}", c1.nome);
        Console.WriteLine("Rodas:      {0}", c1.getRodas());
        Console.WriteLine("Vel.Máxima: {0}", c1.velMax);
        Console.WriteLine("Ligado:     {0}", c1.getLigado());

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("---------------------------------------");

        Console.WriteLine("cor:        {0}", cc1.cor);
        Console.WriteLine("nome:       {0}", cc1.nome);
        Console.WriteLine("Rodas:      {0}", cc1.getRodas());
        Console.WriteLine("Vel.Máxima: {0}", cc1.velMax);
        Console.WriteLine("Ligado:     {0}", cc1.getLigado());
        Console.WriteLine("munições:   {0}", cc1.muniçao);
    }
}