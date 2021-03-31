using System;

// MEMBROS PROTECTED

public class VeiculoBase
{   
    public int velAtual;
    private int velMax;
    protected bool ligado;
    
    //constuctor
    public VeiculoBase(int velMax)
    {
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

}

// classe derivada
class VeiculoDerivate:VeiculoBase
{
   public string nome;
   public VeiculoDerivate(string nome, int velMaxTwo):base(velMaxTwo)
   {
       this.nome = nome;
       ligado = true;
   }
   // métodos
   public bool getLigado()
   {
       return ligado;
   }
   public int getVelMax()
   {
       return VelMax;
   }
}

class Program
{
    static void Main()
    {
       VeiculoDerivate veiculo = new VeiculoDerivate("Bonitão", 120);

       Console.WriteLine("Nome: {0}", veiculo.nome);
       Console.WriteLine("Ve.Máxima: {0}", veiculo.getVelMax()); 
       Console.WriteLine("Ligado: {0}", veiculo.getLigado());      

    }
}
    
