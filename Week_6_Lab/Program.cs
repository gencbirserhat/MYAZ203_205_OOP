namespace Week_6_Lab
{
	class Program
	{
		static void Main()
		{
			List<Product> productList = new List<Product> 
			{
				new Product(1, "Product A",15,7),
                new Product(2, "Product B",4,11),
                new Product(3, "Product C",5,10),
                new Product(4, "Product D",17,45),
                new Product(5, "Product E",9,20),
            };
            Product product = new Product(productList);
			product.GetProduct();

			
        }
	}
}