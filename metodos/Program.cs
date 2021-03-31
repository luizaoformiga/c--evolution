using System;

namespace metodos
{
    class Program
    {
        static void Main(string[] args)
        {
           int tempo = 0;
           char escolha;

           // Menu
           inicio:

           Console.Clear();

           Console.WriteLine("Belo Horizonte /MG a Vitória/ES");
           Console.WriteLine("Escolha o transporte: [a]Avião | [b]Carro | [c] Moto: ");

           escolha = char.Parse(Console.ReadLine()); 

           // Condiçao para escolha
           switch (escolha)
           {
                case 'a':
                case 'A':
                   tempo = 50;
                   break;
                
                case 'b':
                case 'B':
                   tempo = 480;
                   break;
                
                case 'c':
                case 'C':
                   tempo = 600;
                    break;

                default:
                   tempo = 1;  
                   break;
           }
           
           // respostas
           if (tempo < 0)
           {
               Console.WriteLine("Transporte Indisponível");
           } else 
           {
               Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
           }

           Console.WriteLine("Calcular outro transporte [s] | [n]");
           escolha = char.Parse(Console.ReadLine());

           // resumo final 
           if (escolha == 's' || escolha == 'S')
           {
              goto inicio; 
           } else 
           {
               Console.Clear();
               Console.WriteLine("Finalizou por aqui! \nMuito Obrigado");
           }
        }
    }
}
