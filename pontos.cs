using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class pontos 
{
  // UP \\
  public static void ptsjogo ()
  { 
  
            // Gravação dos dados no ficheiro
            
            Console.WriteLine(" \n DIGITE SEU NOME  \n");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            // Gerendo pontuação
            Random numAleatorio = new Random();
            int pts = numAleatorio.Next(0,50);

            // Gravação dos dados no ficheiro
            string ficheiro = @"VOTOS.txt";
            // abrindo sw poderia ser qual quer nome
            StreamWriter sw;
            if (File.Exists(ficheiro) == true)
            {
                sw = File.AppendText(ficheiro);
            }
            else
            {
                sw = File.CreateText(ficheiro);
            } 
            // apenas a criação da linha 
            string linha = nome + "  ;   " + pts.ToString() + " Pts";
            // escrita da linha 
            sw.WriteLine(linha);
            // toda vez tem que fechar
            sw.Close();
}
        //------------------------
        // 2 - CONSULTA 
        //------------------------
      public static void consultapts()
        {
            Console.Clear();
            string ficheiro = @"VOTOS.txt";

            // LER ARQUIVO
            StreamReader sr;

            // VERIFICAÇÂO
            if (File.Exists(ficheiro) == true)
            {
                Console.WriteLine("\tNOME\t\t PONTOS");
                // ABRE O ARQUIVO
                sr = File.OpenText(ficheiro);
                string linha = "";
                // ENQUANTO A LINHA NÂO FOR NULA CONTINUA LENDO
                while ((linha = sr.ReadLine()) != null)
                {
                    // Criando array com a quantidade de variaveis
                    string[] campos = new string[2];
                    // Identifica o separador
                    campos = linha.Split(';');
                    
                    Console.WriteLine("{0}\t\t{1}", campos[0], campos[1]);
                }
                sr.Close();
            }
            else
            {
                Console.WriteLine("Não existe nenhum ficheiro.");
            }
            //Console.ReadLine();
        }

  }
