public class Uno(IPneu pneu) : ICarro, ICustomizavel, IRadio, IArCondicionado
{
    private IPneu pneu = pneu; // Menor acoplamento [Principio D]
    private Placa placa = new(new(new("curitiba"), "parana")); // O ideal aqui seria criar a cidade antes como instancia e referenciar aqui!
    public void Acelerar() 
    => Console.WriteLine("Acelerando..");
    public void AlterarJanela()
    => Console.WriteLine("Abrindo/Fechando janela");
    public void AlterarPorta()
    => Console.WriteLine("Abrindo/Fechando Porta");
    public void AlterarPortaMalas()
    => Console.WriteLine("Abrindo/Fechando PortaMalas");
    public void Buzinar()
    => Console.WriteLine("Bip Bip!!");
    public void Desligar()
    => Console.WriteLine("Zzz...");
    public void Estacionar()
    => Console.WriteLine("Estacionando.");
    public void Frear()
    => Console.WriteLine("Freando");
    public void Ligar()
    => Console.WriteLine("VROOOMM VROOOOMM");
    public void VerificarGasolina()
    => Console.WriteLine("Tanque na metade");
    public void Viajar(ILocal local) // Agora o usuário só pode viajar para locais que de fato existem!
    => Console.WriteLine($"Viajando até {local.Name}"); // Estados também tem propriedade Nome
    public string CidadeDeOrigem()
    => placa.GetCityName();
    public void AtivarNitro()
    => throw new NotImplementedException("");
    public void AlterarArCondicionado()
    => throw new NotImplementedException("");
    public void AtivarPilotoAutomatico()
    => throw new NotImplementedException("");
    public void MedirPressaoDosPneus()
    => throw new NotImplementedException("");
    public void LigarArCondicionado()
    => throw new NotImplementedException("");
    public void DesligarArCondicionado()
    => throw new NotImplementedException("");
    public void AlterarModoArCondicionado(string modo)
    => throw new NotImplementedException("");

    public void LigarRadio()
    => Console.WriteLine("Radio ligado");
    public void DesligarRadio()
    => Console.WriteLine("Radio desligado");
    public void AlterarEstacaoRadio(string estacao)
    => Console.WriteLine("Estacao alt... 98 FM");
    public void AumentarVolumeRadio()
        => Console.WriteLine("Volume +1");
    public void DiminuirVolumeRadio()
        => Console.WriteLine("Volume -1");

}