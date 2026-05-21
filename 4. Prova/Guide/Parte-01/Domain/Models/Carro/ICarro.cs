public interface ICarro
{
    // Muitos métodos foram migrados para outras interfaces [Principio I]
    // Aqui tem apenas coisas que CARROS fazem...
    void Viajar(ILocal local); // Viaja apenas para locais existentes
    string CidadeDeOrigem();
    void Acelerar();
    void Frear();
    void Buzinar();
    void Estacionar();
    void VerificarGasolina();
    void Ligar();
    void Desligar();
    void AtivarPilotoAutomatico();
    void MedirPressaoDosPneus();
    void AtivarNitro();
}