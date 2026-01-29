using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Mang_bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = null;
            if (n > 0)
            {
                arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhap ptu [{i}]: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }
            if (arr == null)
            {
                Console.WriteLine("Loi: Mang chua duoc khoi tao");
                return;
            }

            int tong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                tong += arr[i];
            }
            Console.WriteLine("Tong cac phan tu: " + tong);
        }
    }
}
