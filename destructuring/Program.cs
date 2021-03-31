using System;

//destructor
namespace destructuing 
{
    class Jogador 
    {
       public int energia; 
       public string nome;
       public bool vivo;

       public Jogador(string nes)
       {
           energia = 100;
           vivo = true;
           nome = nes;
       }
       public Jogador(string nes, int num = 200)
       {
           energia = num;
           vivo = true;
           nome = nes;
       }
       public Jogador()
       {
           energia = 100;
           vivo = true;
           nome = "";
       }

       public void information()
       {
           Console.WriteLine("Nome jogador :{0}", nome);
           Console.WriteLine("Energia jogador: {0}", energia);
           Console.WriteLine("Estado jogador: {0}\n", vivo);
       }
       static void Main()
       {
           Jogador PlayOne = new Jogador();
           Jogador PlayTwo = new Jogador();
           Jogador PlayThree = new Jogador();

           PlayOne.information();
           PlayTwo.information();
           PlayThree.information();
       }
    }
}



// o desctructuring tem como sitaxe especial o ~ para indicar que ele é um objeto destrutor