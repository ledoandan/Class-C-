using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Mang_bai6
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
                    Console.Write($"Nhap ptu thu [{i+1}]: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }
            if (arr == null)
            {
                Console.WriteLine("So phan tu chan: 0");
                return;
            }
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    dem++;
                }
            }
            Console.WriteLine("So phan tu chan: " + dem);
        }
    }
}
