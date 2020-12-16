using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class equacao
{
  public static void calculadora ()
  {
  Console.WriteLine("══════════════════════════════════════════════");        
        
        // instanciando calsse 
        segundograu calculo1 = new segundograu (0,0,0);
        // variaveis da equação
        double x1, x2, Delta;
        // VALORES INSERIDOS PELO USUARIO

        try // tentar
        {
        
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine(" DIGITE O VALOR DA VARIAVEL A ➡️ ");
        double valorA = double.Parse(Console.ReadLine());
        Console.WriteLine(" DIGITE O VALOR DA VARIAVEL B ➡️ ");
        double valorB = double.Parse(Console.ReadLine());
        Console.WriteLine(" DIGITE O VALOR DA VARIAVEL c ➡️ ");
        double valorC = double.Parse(Console.ReadLine());
         
        
        // VALIDANDO VALORES DO USUARIO
        calculo1.setvalor1(valorA);
        calculo1.setvalor2(valorB);
        calculo1.setvalor3(valorC);

        // CALCULOS DA EQUAÇÂO 
        Delta = ((valorB * valorB) - 4 * valorA * valorC );
        x1 = (-valorB + Math.Sqrt(Delta)) / (2 * valorA);
        x2 = (-valorB - Math.Sqrt(Delta)) / (2 * valorA);

        Console.WriteLine("CALCULO DA EQUAÇÂO SOLITICADA");
        Console.WriteLine($"{valorA}X² + {valorB}X +  {valorC} = 0 ");

        // REGRA DA EQUAÇÂO
        if ( Delta < 0)
        {
          Console.WriteLine(" ⚠️  A equação de 2º grau não possui raízes reais! ⚠️ ");
        }
        else 
          Console.WriteLine($" VALOR DE DELTA: {Delta}");
          Console.WriteLine($" VALOR DE X1: {x1}");
          Console.WriteLine($" VALOR DE X1: {x2}");
        }
        
        // pegar
        catch (FormatException) 
        {    
          Console.WriteLine("❌❌❌  VALOR DA VARIAVEL INCORRETO   ❌❌❌");
        }
        Console.WriteLine(@"
        DIGITE ENTER PARA VOLTAR INICIO");
        Console.ReadKey();
        
        
        // ❌❌❌ FIM  DO CODIGO DA CALCULADORA DE EQUAÇÂO SEGUNDO GRAU  
}
}