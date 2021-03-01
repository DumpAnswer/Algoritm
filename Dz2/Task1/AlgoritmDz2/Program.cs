using System;
using System.Collections.Generic;

namespace AlgoritmDz2
{
    class Program
    {
        static void Main(string[] args)
         {
            //Создание класса элемент
            NodeArganaize element = new NodeArganaize();

            //Добавление элементов
            Console.WriteLine("Добавление элемента");
            element.AddNode(35);
            element.AddNode(42);
            element.AddNode(125);
            element.AddNode(133);            
            element.AddNode(55);            
            element.PrintList(element.Startnode);

            //Добавление элемента в любое место
            element.AddNodeAfter(element.Endnode, 99);
            Console.WriteLine("Добавление элемента в конец");
            element.PrintList(element.Startnode);

            //Добавление элемента в середину
            element.AddNodeAfter(element.Startnode.NextNode.NextNode, 13);
            Console.WriteLine("Добавление элемента в середину");
            element.PrintList(element.Startnode);


            //Поиск элемента по значению
            var testnode = element.FindNode(125);

            //Удаление элемента через индекс
            Console.WriteLine("Удаление элемента  через индекс ");
            element.RemoveNode(1);
            element.PrintList(element.Startnode);

            //Удаление через ноду
            Console.WriteLine("Удаление значения через ноду");
            element.RemoveNode(testnode);
            element.PrintList(element.Startnode);




        }
       



    }
}
