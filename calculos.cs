using System;

class segundograu {
  double valor1;
  double valor2;
  double valor3;

  // SOBRE CARGA DE CONTRUTOR
  public segundograu (double v1, double v2, double v3){
    valor1 = v1;
    valor2 = v2;
    valor3 = v3;    
  }
  
  // CONTRUTOR
  public segundograu ()
  {
    valor1 = 10;
    valor2 = 20;
    valor3 = 30;
  }

  public double getvalor1 (){
    return valor1;
  }

  // TRATAMENTO DE ERRO 01 <- forma
  public void setvalor1 (double v1){
    try 
    {
      valor1 = v1;
    }
    catch (FormatException)
    {    
      Console.WriteLine("VALOR DA VARIAVEL (A) INCORRETO");
    }
  }

  public double getvalor2 (){
    return valor2;
  }

  // TRATAMENTO DE ERRO 02 <- forma
  public void setvalor2 (double v2){
    if ( v2 < 0 )
      // jogar 
      throw new Exception("VALOR DA VARIAVEL (B) INCORRETO");
    else
      valor2 = v2;
  }

  public double getvalor3 (){
    return valor3;
  }

  // TRATAMENTO DE ERRO 02 <- forma
  public void setvalor3 (double v3){
    if ( v3 < 0 )
      throw new Exception("VALOR DA VARIAVEL (C) INCORRETO");
    else
      valor3 = v3;
  }

  
}