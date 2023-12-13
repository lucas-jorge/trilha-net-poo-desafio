namespace DesafioPOO.Models
{
using System;

// Classe abstrata Smartphone
public abstract class Smartphone
{
    public string Numero { get; set; }
    protected string Modelo { get; set; }
    protected string IMEI { get; set; }
    protected int Memoria { get; set; }

    public void Ligar()
    {
        Console.WriteLine("Realizando ligação...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    // Método abstrato para instalar aplicativos
    public abstract void InstalarAplicativo(string nome);
}
}