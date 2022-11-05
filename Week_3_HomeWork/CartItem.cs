namespace Week_3_HomeWork
{
    public class CartItem
    {
        public int CartId { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Ürün Adı : {this.Product.ProductName}\n"+
                   $"Fiyat : {this.Product.Price} \n"+
                   $"Adet : {this.Quantity} \n";
        }

    }
}