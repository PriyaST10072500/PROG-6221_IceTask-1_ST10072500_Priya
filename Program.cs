namespace PROG_IceTask_1_ST10072500_Priya
{

        class Program
        {
            static void Main(string[] args)
            {
                // Instantiating products and shopping cart
                ClothingProduct shirt = new ClothingProduct("T-Shirt", 35.51, ProductCategory.Clothing, "Medium", "Pink");
                ElectronicsProduct phone = new ElectronicsProduct("Smartphone", 800.29, ProductCategory.Electronics, "Samsung", "A 33");
                ShoppingCart cart = new ShoppingCart(5);

                // Adding products to the shopping cart
                cart.AddProduct(shirt);
                cart.AddProduct(phone);

                // Displaying contents of the shopping cart
                Console.WriteLine("Contents of the shopping cart:");
                foreach (Product product in cart.Products)
                {
                    if (product != null)
                        product.GetInfo();
                }

                // Removing a product from the shopping cart
                cart.RemoveProduct(shirt);

                // Displaying updated contents of the shopping cart
                Console.WriteLine("\nUpdated contents of the shopping cart:");
                foreach (Product product in cart.Products)
                {
                    if (product != null)
                        product.GetInfo();
                }
            }
        }
}

    //References 
        //https://www.codecademy.com/learn/learn-c-sharp/modules/learn-csharp-arrays-and-loops/cheatsheet
        //https://stackoverflow.com/questions/295104/what-is-the-difference-between-a-field-and-a-property
        //https://www.geeksforgeeks.org/c-sharp-enumeration-or-enum/
        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods


