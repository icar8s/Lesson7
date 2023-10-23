namespace Lesson7.Classes;

public class Inventory
{
    
    public decimal PriceOfAllProducts()
    {
        decimal sum = 0;

        foreach (var product in products)
        {
            sum += product.Price * product.Quantity;
        }
        return sum;
    }
    
        private List<Product> products; 
        
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
      


    }