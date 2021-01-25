using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using module3.MyClasses;
using module3.Module;

namespace module3
{
    public class Cakes
    {
        public string Flavor { get; set; }
        public string Type { get; set; }

        public void AddFlavor<T>(T parameter)

        {

            this.Flavor = parameter as string;
            this.Type = parameter as string;

        }
        static void Main(string[] args)
        {
            Cakes myCakes = new Cakes();
            myCakes.Type = "Wedding";
            myCakes.AddFlavor<string>("Vanilla");

            Cakes myCakes2 = new Cakes();
            myCakes.Type = "Birthday";
             myCakes.AddFlavor<string>("Chocolate");




        }
    }
    
}

