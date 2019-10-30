using System;
using System.Collections.Generic;
using System.Text;
using ListsProjects.Domain;

namespace ListsProjects.LIst
{
    public class InterateList
    {
        public InterateList()
        {
           var carsList = new List<Car>(4);

            //Adicionando campos à lista
            carsList.Add(new Car("Ferrari", "GTB-250", 2500000.00));
            carsList.Add(new Car("Lamborguini", "Aventador", 1050000.00));
            carsList.Add(new Car("Tesla", "Roadster", 880000.00));
            carsList.Add(new Car("Mercedez-Benz", "GT Black Series", 1300000.00));
            carsList.Add(new Car("Bentley", "Continental", 1599999.00));

            //Adicionando um elemento à um index
            carsList.Insert(5, new Car("Ford", "Shelby-500", 900000.00));

            // Removendo um item da lista
            var car = new Car("Tesla", "GTB-250", 880000.00);
            carsList.Remove(car);

            // Removendo um item pelo index 3
            carsList.RemoveAt(3);

            // Retorna o item no index 0
            var first = carsList[0];

            var car2 = new Car("Tesla", "Roadster", 880000.00);
            // Retorna o index para um item específico
            var index = carsList.IndexOf(car2);

            // Checa se na lista existe um item car2
            var contains = carsList.Contains(car2);

            // Retorna o numbero de items na lista 
            var count = carsList.Count;

            // Faz iterações em todos os itens da lista
            foreach (var item in carsList)
                Console.WriteLine(item);
        }
    }
}
