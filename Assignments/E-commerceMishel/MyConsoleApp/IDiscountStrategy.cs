namespace MyConsoleApp
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal totalAmount);
    }
}