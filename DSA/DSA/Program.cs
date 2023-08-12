using System;

namespace DSA // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string v = "";
                string[] arr = new string[8];
                for (int i = 0; i < 8; i++)
                {
                    arr[i] = Console.ReadLine();
                }
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        string temp = arr[i][j].ToString();
                        if (!temp.Equals("."))
                        {
                            v += arr[i][j];
                        }
                    }
                }
                Console.WriteLine(v);
                t--;
            }
        }   
    }
}