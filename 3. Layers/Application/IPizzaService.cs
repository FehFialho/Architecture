using Domain;

namespace Application;
public interface IPizzaService
{
    void CutPizza();
    void ServePizza();
    void AddPizza(PizzaDTO pizza){}
    int GetPizzaQuantity();
}