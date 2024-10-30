namespace MyConsoleApp
{
    public class PercentageDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal _discountPercentage = 2;
        
        public decimal ApplyDiscount(decimal totalAmount) => totalAmount - (totalAmount * _discountPercentage / 100);
    }
}