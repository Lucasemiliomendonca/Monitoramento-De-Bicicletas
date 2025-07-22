using System;

class Bicicleta
{
    static void Main()
    {
       
        string modelo = Console.ReadLine()!;

        
        string nivelStr = Console.ReadLine()!;
        int nivelBateria = int.Parse(nivelStr);

        
        BicicletaInterna bicicleta = new BicicletaInterna(modelo, nivelBateria);

        
        Console.WriteLine(bicicleta.ObterMensagem());
    }
}


class BicicletaInterna
{
    private string modelo;
    private int nivelBateria;

    
    
    public BicicletaInterna (string modelo, int nivelBateria)
    {
      this.modelo = modelo;
      this.nivelBateria = nivelBateria;
    }

    
    public decimal CalcularDistancia()
    {
      return nivelBateria * 0.5M;
    }

    public string ObterMensagem()
    {
        return $"{modelo}: Distancia estimada = {CalcularDistancia():F1} km";
    }
}




