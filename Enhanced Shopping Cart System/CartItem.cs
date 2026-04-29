using ShoppingCartSystem;

namespace ShoppingCartSystem
{
    public class CartItem
    {
        public Product Product;
        public int Quantity;

        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
