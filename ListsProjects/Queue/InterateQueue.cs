using System;
using System.Collections.Generic;
using System.Text;

namespace ListsProjects.Queue
{
    public class InterateQueue
    {
        public InterateQueue()
        {
            var queue = new Queue<string>();

            // Adiciona um item na Queue
            queue.Enqueue("transacao1");

            // Verifica se contém um determinado item na Queue
            var contains = queue.Contains("transacao1");

            // Remove e retorna o item na frente da Queue
            var front = queue.Dequeue();

            // Retorna o item na frente da Queue sem remover
            var top = queue.Peek();

            // Remove todos os itens
            queue.Clear();

            // Numeros de items da Queue
            var count = queue.Count;
        }
    }
}
