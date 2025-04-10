namespace eShop.Basket.API.Model;

public class CustomerBasket
{
    public int Id { get; set; }

    public List<BasketItem> Items { get; set; } = [];

    public CustomerBasket() { }

    public CustomerBasket(int customerId)
    {
        Id = customerId;
    }
}
