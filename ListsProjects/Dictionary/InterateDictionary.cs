using System;
using System.Collections.Generic;
using System.Text;
using ListsProjects.Domain;

namespace ListsProjects.Dictionary
{
    public class InterateDictionary
    {
        public InterateDictionary()
        {

            Dictionary<int,Car> dicCar=new Dictionary<int, Car>();


            dicCar.Add(1,new Car("Ferrari", "GTB-250", 2500000.00));

            Dictionary<int,Car> dicCar2=new Dictionary<int, Car>
            {
                {2,new Car("Lamborguini", "Aventador", 1050000.00)},
                {3, new Car("Tesla", "Roadster", 880000.00)},
                {4, new Car("Mercedez-Benz", "GT Black Series", 1300000.00)},
                {5, new Car("Bentley", "Continental", 1599999.00)}
            };

            var car = dicCar2[3];

            dicCar.Remove(1);

            dicCar.Clear();


            var count = dicCar2.Count;

            var containsKey = dicCar2.ContainsKey(1);
            var car2 = new Car("Tesla", "Roadster", 880000.00);
            var containsValue = dicCar2.ContainsValue(car);

            // Iteração pelas keys 
            foreach (var key in dicCar2.Keys)
                Console.WriteLine(dicCar2[key]);

            // Iteração pelos valores
            foreach (var value in dicCar2.Values)
                Console.WriteLine(value);

            // Iteração sobre o dictionary
            foreach (var keyValuePair in dicCar2)
            {
                Console.WriteLine(keyValuePair.Key);
                Console.WriteLine(keyValuePair.Value);
            }
        }
    }
}
