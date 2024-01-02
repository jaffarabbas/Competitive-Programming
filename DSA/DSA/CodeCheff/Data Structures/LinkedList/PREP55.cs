using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Data_Structures.LinkedList
{
    internal class PREP55
    {
        public static LinkedList<T> RemoveDuplicates<T>(LinkedList<T> linkedList)
        {
            HashSet<T> uniqueElements = new HashSet<T>();
            LinkedList<T> result = new LinkedList<T>();

            foreach (var item in linkedList)
            {
                if (uniqueElements.Add(item))
                {
                    result.AddLast(item);
                }
            }

            return result;
        }
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int t2 = int.Parse(Console.ReadLine());
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                LinkedList<int> list = new LinkedList<int>();
                for (int i = 0; i < t2; i++)
                {
                    list.AddLast(l[i]);
                }
                LinkedList<int> result = RemoveDuplicates(list);
                foreach (var item in result)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
