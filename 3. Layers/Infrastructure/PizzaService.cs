using Application;
using Domain;

namespace Infrastructure;

public class PizzaService : IPizzaService
{
    List<Pizza> Pizzas = [];

    public void AddPizza(PizzaDTO pizza)
    {
        var newPizza = new Pizza()
        {
            Flavour = pizza.Flavour,
            Slices = pizza.Slices
        };
        Pizzas.Add(newPizza);        
    }
    public void CutPizza()
    {
        Console.WriteLine("[Infra] Pizza Cutted!");
    }

    public int GetPizzaQuantity()
    {
        return Pizzas.Count;
    }

    public void ServePizza()
    {
        Console.WriteLine("[Infra] Pizza served!");
    }
}