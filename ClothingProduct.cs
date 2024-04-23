using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_IceTask_1_ST10072500_Priya
{
    // Derived class for clothing products
    public class ClothingProduct : Product
    {
        // Fields
        private string size;
        private string color;

        // Properties
        public string Size { get { return size; } }
        public string Color { get { return color; } }

        // Constructor
        public ClothingProduct(string name, double price, ProductCategory category, string size, string color)
            : base(name, price, category)
        {
            this.size = size;
            this.color = color;
        }

        // Method to get information about the clothing product
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Size: {size}, Color: {color}");
        }
    }

}

    //References 
        //https://www.codecademy.com/learn/learn-c-sharp/modules/learn-csharp-arrays-and-loops/cheatsheet
        //https://stackoverflow.com/questions/295104/what-is-the-difference-between-a-field-and-a-property
        //https://www.geeksforgeeks.org/c-sharp-enumeration-or-enum/
        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
