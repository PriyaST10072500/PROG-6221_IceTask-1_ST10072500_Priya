using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_IceTask_1_ST10072500_Priya
{
    // Base class for all products
    public class Product
    {
        // Fields
        private string name;
        private double price;
        private ProductCategory category;

        // Properties
        public string Name { get { return name; } }
        public double Price { get { return price; } }
        public ProductCategory Category { get { return category; } }

        // Constructor
        public Product(string name, double price, ProductCategory category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }

        // Method to get information about the product
        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {name}, Price: R{price}, Category: {category}");
        }
    }
}

    //References 
        //https://www.codecademy.com/learn/learn-c-sharp/modules/learn-csharp-arrays-and-loops/cheatsheet
        //https://stackoverflow.com/questions/295104/what-is-the-difference-between-a-field-and-a-property
        //https://www.geeksforgeeks.org/c-sharp-enumeration-or-enum/
        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods