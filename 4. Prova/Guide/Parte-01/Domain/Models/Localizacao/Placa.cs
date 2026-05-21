public class Placa(Estado estado)
{
    public Estado Estado {get;set;} = estado;
    public string GetCityName()
    {
        return Estado.Cidade.GetName(); // [Lei de Demeter]
    }
}