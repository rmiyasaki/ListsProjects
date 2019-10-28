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
            List<Car> lstClients = new List<Car>();

            //Adicionando campos à lista
            lstClients.Add(new Car("Ferrari", "GTB-250", 2500000.00));
            lstClients.Add(new Car("Lamborguini", "Aventador", 1050000.00));
            lstClients.Add(new Car("Tesla", "Roadster", 880000.00));
            lstClients.Add(new Car("Mercedez-Benz", "GT Black Series", 1300000.00));
            lstClients.Add(new Car("Bentley", "Continental", 1599999.00));

            //Adicionando um elemento à um index
            lstClients.Insert(5, new Car("Ford", "Shelby-500", 900000.00));

            // Removendo um item da lista
            var car = new Car("Tesla", "GTB-250", 880000.00);
            lstClients.Remove(car);

            // Removendo um item pelo index 3
            lstClients.RemoveAt(3);

            // Retorna o item no index 0
            var first = lstClients[0];

            var car2 = new Car("Tesla", "Roadster", 880000.00);
            // Retorna o index para um item específico
            var index = lstClients.IndexOf(car2);

            // Checa se na lista existe um item car2
            var contains = lstClients.Contains(car2);

            // Retorna o numbero de items na lista 
            var count = lstClients.Count;

            // Faz iterações em todos os itens da lista
            foreach (var item in lstClients)
                Console.WriteLine(item);
        }
    }
}
