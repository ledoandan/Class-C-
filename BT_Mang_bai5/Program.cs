using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Mang_bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Le Doan Dan + 2415053122305");
            Console.Write("Nhap so phan tu n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = null;

            if (n > 0)
            {
                arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhap ptu[{i+1}]: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Mang rong hoac chua duoc khoi tao");
                return;
            }
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Gia tri lon nhat trong mang: " + max);
        }
    }
}
