using System;
using System.Collections.Generic;
using System.Text;

namespace ListsProjects.Domain
{
    public class Car
    {
        public Car(string brand, string model, double price)
        {
            SetClient(brand,model,price);
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public void SetClient(string brand, string model, double price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }

    }
}
