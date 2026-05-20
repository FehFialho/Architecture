namespace Application.PizzaUseCases;

public class CutPizzaUseCase
(
    IPizzaService service
)
{
    public void Do()
    {
        service.CutPizza();
    }
}