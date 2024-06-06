using System;
using System.Threading; //Lidar com os threadings que vou usar.


class Program
{
    static void Main()
    {
        string poesia = "De tudo ao meu amor serei atento\r\nAntes, e com tal zelo, e sempre, e tanto\r\nQue mesmo em face do maior encanto\r\nDele se encante mais meu pensamento.\r\n\r\nQuero vivê-lo em cada vão momento\r\nE em seu louvor hei de espalhar meu canto\r\nE rir meu riso e derramar meu pranto\r\nAo seu pesar ou seu contentamento\r\n\r\nE assim, quando mais tarde me procure\r\nQuem sabe a morte, angústia de quem vive\r\nQuem sabe a solidão, fim de quem ama\r\n\r\nEu possa me dizer do amor (que tive):\r\nQue não seja imortal, posto que é chama\r\nMas que seja infinito enquanto dure.";
        foreach (char letra in poesia)
        {
            Console.Write(letra);
            Thread.Sleep(70); // Velocidade de exibição da mensagem
        }
    }
}

