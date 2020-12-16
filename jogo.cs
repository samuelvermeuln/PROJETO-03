using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class jogo {
  
  public static void jgs ()
  {
    // UP \\
    string[,] labirinto = new string [4,8]
  {
    {"#","  ","  ","#","#","#","#","#"},
    {"#","#","#","#","#","#","#","#"},
    {"#","  ","  ","#","#","#","#","#"},
    {"#","#","  ","  ","  ","  ","  "," F "},
    
    
  };

  string jogador = "@";
  int PLinha = 3;
  int PColuna = 1;

  bool fim = false;
  // EXIBE O CARRINHO NO LOCAL INDICADO
    labirinto[3,1] = jogador;


    while(!fim)
    {
        Console.Clear();
        // PERCORRENDO O ARRAY
        for (int linha = 0; linha < 4; linha ++)
        {
          for (int coluna = 0; coluna < 8; coluna ++)
          {
            Console.Write(@"{0}",labirinto[linha,coluna]);
          }
          Console.WriteLine();
        }
        // FIM DO FOR
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("");
                Console.WriteLine("╔═════CONTROLE DO CARRINHO══════╗");
                Console.WriteLine("║	  'W' = CIMA 	    ⬆️      	║");
                Console.WriteLine("║	  'S' = BAIXO	    ⬇️        ║");
                Console.WriteLine("║	  'A' = ESQUERDA 	⬅️        ║");
                Console.WriteLine("║	  'D' = DIREITA   ➡️        ║");
                Console.WriteLine("║	  'ENTER' PARA SAIR          ║");
                Console.WriteLine("╚═══════════════════════════════╝");
                Console.WriteLine("");
                // para quem não sabe não pula uma linha
                Console.Write("Direção -->> ");
                // ToUpper() -> joga para maisculo 
                string comando = Console.ReadLine(). ToUpper();

                if (comando == "W")
                {
                  if (labirinto[PLinha -1, PColuna] != "@")
                  {
                    labirinto[PLinha, PColuna] = "  ";
                    PLinha --;
                  }
                }
                else if (comando == "A")
                {
                  if (labirinto[PLinha , PColuna -1] != "@")
                  {
                    labirinto[PLinha, PColuna] = "  ";
                    PColuna --;
                  }
                }
                else if (comando == "S")
                {
                  if (labirinto[PLinha +1 , PColuna ] != "@")
                  {
                    labirinto[PLinha, PColuna] = "  ";
                    PColuna ++;
                  }
                }
                else if (comando == "D")
                {
                  if (labirinto[PLinha , PColuna + 1] != "@")
                  {
                    labirinto[PLinha, PColuna] = "  ";
                    PColuna ++;
                  }
                }
                else                             
                  fim = true;                  
                

                labirinto[PLinha, PColuna] = jogador;

                if (labirinto[3, 7] == jogador)
                  fim = true;
      }
            

  }
}