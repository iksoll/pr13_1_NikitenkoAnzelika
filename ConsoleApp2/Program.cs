using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ArrayList list = new ArrayList();
                List<int> list1 = new List<int>();
                list.Add(6);
                list.Add(7);
                list.Add(5);
                list.Add(7);
                list.Add(9);
                list.Add(8);
          
                list1.Add(1);
                list1.Add(7);
                list1.Add(6);
                list1.Add(8);
                list1.Add(9);
                list1.Add(2);

                foreach (object e in list)
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine();
                foreach (object e in list1)
                {
                    Console.WriteLine(e);
                }
                Console.Write("Введите индекс для вставки одной коллекции в другую: ");
                int n1 = int.Parse(Console.ReadLine());
                list.InsertRange(n1, list1);               
                Console.Write("Введите количeство элементов для удаления: ");
                int k = int.Parse(Console.ReadLine());
                int n = n1 / 2;
                list.RemoveRange(n, k);
                Console.WriteLine("Список после удаления элементов: ");
                foreach (object e in list)
                {
                    Console.WriteLine(e);
                }
                Console.ReadKey();
            }
        }
    }
}
