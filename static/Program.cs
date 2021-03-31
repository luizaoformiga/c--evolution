using System;

namespace Program
{
    class jogador
    {
        static public string nome;
        static public bool atento;
        static public void Jogador(string nes)
        {
            nome = nes;
            atento = true;
        }

        static public void information()
        {
            Console.WriteLine("Jogador {0}", nome);
            Console.WriteLine("Está atento? {0}", atento);
        }
        static void Main()
        {
           //Jogador one = new Jogador("Luiz");
        }
    }
}
