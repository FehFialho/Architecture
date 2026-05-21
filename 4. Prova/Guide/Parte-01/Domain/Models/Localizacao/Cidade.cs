public class Cidade(string name) : ILocal
{
    public string Name {get;set;} = name;

    public string GetName() // [Lei de Demeter]
    {
        return Name;
    }
}