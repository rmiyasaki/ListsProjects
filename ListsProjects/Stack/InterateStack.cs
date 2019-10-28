using System;
using System.Collections.Generic;
using System.Text;

namespace ListsProjects.Stack
{
    public class InterateStack
    {
        public InterateStack()
        {
            var stack = new Stack<string>();

            // Adicionando items
            stack.Push("https://www.webmotors.com.br/");

            // Checkando se contém stack 
            var contains = stack.Contains("https://www.webmotors.com.br/");

            // Remove e retorna o ultimo item do Stack
            var top = stack.Pop();

            // Retorna o ultimo item do Stack sem remover
            var top2 = stack.Peek();

            // Retorna o numero de itens 
            var count = stack.Count;

            // Remove todos os itens
            stack.Clear();
        }
    }
}
