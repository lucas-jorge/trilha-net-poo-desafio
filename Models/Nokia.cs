namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
public class Nokia : Smartphone
{
    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando {nome} no Nokia...");
    }
}
}