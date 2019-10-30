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

            Dictionary<int,Car> carsDic=new Dictionary<int, Car>();


            carsDic.Add(1,new Car("Ferrari", "GTB-250", 2500000.00));

            Dictionary<int,Car> carsDic2=new Dictionary<int, Car>
            {
                {2,new Car("Lamborguini", "Aventador", 1050000.00)},
                {3, new Car("Tesla", "Roadster", 880000.00)},
                {4, new Car("Mercedez-Benz", "GT Black Series", 1300000.00)},
                {5, new Car("Bentley", "Continental", 1599999.00)}
            };

            var car = carsDic2[3];

            carsDic.Remove(1);

            carsDic.Clear();


            var count = carsDic2.Count;

            var containsKey = carsDic2.ContainsKey(1);
            var car2 = new Car("Tesla", "Roadster", 880000.00);
            var containsValue = carsDic2.ContainsValue(car);

            // Iteração pelas keys 
            foreach (var key in carsDic2.Keys)
                Console.WriteLine(carsDic2[key]);

            // Iteração pelos valores
            foreach (var value in carsDic2.Values)
                Console.WriteLine(value);

            // Iteração sobre o dictionary
            foreach (var keyValuePair in carsDic2)
            {
                Console.WriteLine(keyValuePair.Key);
                Console.WriteLine(keyValuePair.Value);
            }
        }
    }
}
