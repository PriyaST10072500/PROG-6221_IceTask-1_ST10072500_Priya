using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_IceTask_1_ST10072500_Priya
{
    // Derived class for electronics products
    public class ElectronicsProduct : Product
    {
        // Fields
        private string brand;
        private string model;

        // Properties
        public string Brand { get { return brand; } }
        public string Model { get { return model; } }

        // Constructor
        public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model)
            : base(name, price, category)
        {
            this.brand = brand;
            this.model = model;
        }

        // Method to get information about the electronics product
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Brand: {brand}, Model: {model}");
        }
    }
}

    //References 
        //https://www.codecademy.com/learn/learn-c-sharp/modules/learn-csharp-arrays-and-loops/cheatsheet
        //https://stackoverflow.com/questions/295104/what-is-the-difference-between-a-field-and-a-property
        //https://www.geeksforgeeks.org/c-sharp-enumeration-or-enum/
        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods