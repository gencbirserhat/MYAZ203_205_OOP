namespace Week_3_HomeWork
{
    public class ShoppingItem
    {
        private List<CartItem> _cartItems;

        public ShoppingItem()
        {
            _cartItems = new List<CartItem>();

        }

        public void Add(CartItem cartItem) { _cartItems.Add(cartItem); }
        public void Remove(int id) 
        {
            var item = _cartItems.FirstOrDefault(item => item.CartId == id);
            if (item != null) { _cartItems.Remove(item); }
            else
            {
                throw new Exception("CartItem Not Found");
            }
        }

        public void GetBalance()
        {
            int sum = 0;
            foreach (var item in _cartItems)
            {
                int totalPrice =  (item.Product.Price) * (item.Quantity);
                sum += totalPrice;
                
            }
            
            Console.WriteLine($"Total Price: {sum}");
        }

        public void GetList()
        {
            _cartItems.ForEach(item => Console.WriteLine(item));
        }
    }
}