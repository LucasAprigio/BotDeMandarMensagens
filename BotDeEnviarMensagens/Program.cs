using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace BotDeEnviarMensagens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensagem = "";
            int quantidadeMensagem = 0;
            int contador = 10;

            var inputSimulator = new InputSimulator();


            Console.WriteLine("Qual mensagem você deseja enviar?");
            mensagem = Console.ReadLine();

            Console.WriteLine("Quantas mensagens deseja enviar?");
            quantidadeMensagem = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("----------------------> " + (contador - i));
                Thread.Sleep(1000);
            }

            Console.WriteLine("Jaaaaaaaaaaaa!!!!!");

            for (int i = 0; i < quantidadeMensagem; i++)
            {
                inputSimulator.Keyboard.TextEntry(mensagem);
                inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(250);
            }
        }
    }
}
