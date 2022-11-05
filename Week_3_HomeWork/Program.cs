namespace Week_3_HomeWork
{
    public class Program
    {
        public static void Main()
        {
            var product1 = new Product()
            {
                Price = 1000,
                ProductId = 1,
                ProductName = "Headphones"
            };
            var product2 = new Product()
            {
                ProductId = 2,
                Price = 5000,
                ProductName = "iPhone"
            };

            var cartItem1 = new CartItem()
            {
                CartId = 1,
                Product = product1,
                Quantity = 3,
            };
            var cartItem2 = new CartItem()
            {
                CartId = 2,
                Product = product2,
                Quantity = 2,
            };

            var basket = new ShoppingItem();

            basket.Add(cartItem1);
            basket.Add(cartItem2);
            basket.GetList();
            basket.GetBalance();
            


        }
    }
}