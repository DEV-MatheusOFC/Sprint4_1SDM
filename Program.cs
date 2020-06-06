using System;

namespace CelularPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular samsung = new Celular();

            samsung.modelo = "Samsung Galaxy A20";
            samsung.cor = "Preto";

            Console.WriteLine("Deseja ligar o celular?");
            samsung.ligado = Boolean.Parse(Console.ReadLine());

            if(samsung.ligado){

                while(samsung.ligado == true){

                    Console.WriteLine("Qual ação deseja realizar? \n 1 - Fazer Ligação \n 2 - Enviar Mensagem \n 3 - Desligar");
                    int resposta = Int32.Parse(Console.ReadLine() );

                    switch (resposta)
                    {
                        case 1:
                        Console.WriteLine(samsung.FazerLigacao());
                        break;

                        case 2:
                        Console.WriteLine(samsung.EnviarMensagem());
                        break;

                        case 3:
                        Console.WriteLine(samsung.Desligar());
                        break;

                        default:
                        Console.WriteLine(samsung.Ligar());
                        break;
                    }
                }


            }else{
                Console.WriteLine("Celular Desligado");
            } 

        }
    }           
}