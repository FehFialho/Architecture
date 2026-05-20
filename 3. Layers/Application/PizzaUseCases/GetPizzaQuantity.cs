namespace Application.PizzaUseCases;

public class GetPizzaQuantityUseCase(
    IPizzaService service
)
{
    public int Do()
    {
        return service.GetPizzaQuantity();
    }
}