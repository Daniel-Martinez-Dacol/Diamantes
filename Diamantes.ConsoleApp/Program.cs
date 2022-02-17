using System;

namespace Diamantes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alfabeto convertido em Array:
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVXWYZ";
            char[] alfabetoArray = alfabeto.ToCharArray();
            
            //Letra que o Usuario vai digitar:
            Console.Write("Digite uma letra: ");
            string letraDoUsuario = Console.ReadLine();

            //Variavel responsavel por converter a posição da letra em valor int:
            int valorDaLetra = alfabeto.IndexOf(letraDoUsuario);

            int quantidadeDeEspacosEntreAsLetras = 1;
            int quantidadeDeEspaçosAntesDasLetras = valorDaLetra;
            


            #region PARTE DE CIMA
            for (int linha = 0; linha < valorDaLetra; linha++)
            {

                for (int i = 0; i < quantidadeDeEspaçosAntesDasLetras; i++)
                {
                    Console.Write(" ");
                }
               
                if (linha > 0)
                {
                    Console.Write(alfabetoArray[linha]);
                }
                
                for (int i = 0; i < quantidadeDeEspacosEntreAsLetras; i++)
                {
                    Console.Write(" ");
                }
                
                Console.Write(alfabetoArray[linha]);
                
                quantidadeDeEspaçosAntesDasLetras--;
                quantidadeDeEspacosEntreAsLetras += 2;

                Console.WriteLine();
            }

            #endregion

            #region PARTE DE BAIXO
            for (int linha = valorDaLetra; linha >= 0; linha--)
            {
                for (int i = 0; i < quantidadeDeEspaçosAntesDasLetras; i++)
                {
                    Console.Write(" ");
                }

                if (linha > 0)
                {
                    Console.Write(alfabetoArray[linha]);
                }

                for (int i = 0; i < quantidadeDeEspacosEntreAsLetras; i++)
                {
                    Console.Write(" ");
                }
               
                Console.Write(alfabetoArray[linha]);
                
                quantidadeDeEspaçosAntesDasLetras++;
                quantidadeDeEspacosEntreAsLetras -= 2;
               
                Console.WriteLine();
            }
            #endregion

            Console.ReadLine();
        }
    }
}
