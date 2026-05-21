public class Estado(Cidade cidade, string name) : ILocal
{
    public string Name {get;set;} = name;
    public Cidade Cidade {get;set;} = cidade;
}