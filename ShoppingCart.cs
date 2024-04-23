using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_IceTask_1_ST10072500_Priya
{

    public enum ProductCategory
    {
        Clothing,
        Electronics,
        Home,
        Beauty,
        Groceries
    }

    // Class representing a shopping cart
    public class ShoppingCart
    {
        // Fields
        private Product[] products;
        private int itemCount;

        // Properties
        public Product[] Products { get { return products; } }
        public int ItemCount { get { return itemCount; } }

        // Constructor
        public ShoppingCart(int capacity)
        {
            products = new Product[capacity];
            itemCount = 0;
        }

        // Method to add a product to the shopping cart
        public void AddProduct(Product product)
        {
            if (itemCount < products.Length)
            {
                products[itemCount] = product;
                itemCount++;
            }
            else
            {
                Console.WriteLine("Shopping cart is full.");
            }
        }

        // Method to remove a product from the shopping cart
        public void RemoveProduct(Product product)
        {
            for (int i = 0; i < itemCount; i++)
            {
                if (products[i] == product)
                {
                    for (int j = i; j < itemCount - 1; j++)
                    {
                        products[j] = products[j + 1];
                    }
                    products[itemCount - 1] = null;
                    itemCount--;
                    return;
                }
            }
            Console.WriteLine("Product not found in the shopping cart.");
        }
    }

}

    //References 
        //https://www.codecademy.com/learn/learn-c-sharp/modules/learn-csharp-arrays-and-loops/cheatsheet
        //https://stackoverflow.com/questions/295104/what-is-the-difference-between-a-field-and-a-property
        //https://www.geeksforgeeks.org/c-sharp-enumeration-or-enum/
        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods