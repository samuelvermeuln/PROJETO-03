using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Console.Clear();

    while (true)
    {  
      Console.Clear();
      // COR DO CONSOLE
      Console.ForegroundColor = ConsoleColor.Blue;

      //    MENU     ||
    // 1º - Primeiro jogo
    // 2º - Distancia Euclidiana

    Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ 💥💥💥 PROJETO 03 💥💥💥 ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");

    Console.WriteLine ("");
    Console.WriteLine ("");

    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("╔═════════════════MENU DE OPÇÕES════════════════╗");
    Console.WriteLine("║ PARA INCIAR ESCOLHA UMA OPÇÃO                 ║");
    Console.WriteLine("║ DIGITE 1️⃣ Para o jogo      🕹️                ║");    
    Console.WriteLine("║ DIGITE 2️⃣ Para Calculos    🔢                ║");
    Console.WriteLine("║ DIGITE 3️⃣ Para Pontuação do jogo    🕹️       ║");
    Console.WriteLine("║ TECLE ESC PARA FINALIZAR TUDO !               ║");
    Console.WriteLine("╚═══════════════════════════════════════════════╝");
     Console.ForegroundColor = ConsoleColor.White;    
    
      // INICO DE TUDO
      var control_menu = Console.ReadKey(false).Key;      
      switch(control_menu)      
      { 
        // ❌❌❌ COMEÇO DO CODIGO DO JOGO       
        case ConsoleKey.D1 :
        
        Console.WriteLine("══════════════════════════════════════════════");
        
        jogo.jgs ();

        Console.WriteLine(" \n PARABENS VOCÊ GANHOU !!!  \n");
        Console.WriteLine(@"
        DIGITE ENTER PARA VOLTAR INICIO");
        Console.ReadKey();
        break;


        // ❌❌❌ COMEÇO DO CODIGO DA CALCULADORA DE EQUAÇÂO SEGUNDO GRAU  
        case ConsoleKey.D2:
         equacao.calculadora ();
        break;

        // ❌❌❌ COMEÇO DO CODIGO DA PONTUAÇÃO  
        case ConsoleKey.D3 :
        Console.WriteLine("══════════════════════════════════════════════");
        pontos.ptsjogo ();
        pontos.consultapts ();

        Console.WriteLine(@"
        DIGITE ENTER PARA VOLTAR INICIO");
        Console.ReadKey();
        break;

        case ConsoleKey.Escape:        
              Console.Clear();
              Console.WriteLine($@"
              FIM ...
              Muito Obrigado!!
              ");        
        return;
        
      }      
    }
       
  }
}