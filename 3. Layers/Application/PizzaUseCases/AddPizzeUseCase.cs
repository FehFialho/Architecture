namespace Application.PizzaUseCases;

public class AddPizzeUseCase(IPizzaService service)
{
    public void Do(PizzaDTO pizza)
    {
        if(pizza.Flavour.Count() < 3)
        {
            Console.WriteLine("[Application] Flavour name must be bigger than 3 length!");
            return;
        }
        service.AddPizza(pizza);
    }   
}