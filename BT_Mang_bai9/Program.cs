using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Mang_bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Le Doan Dan + 2415053122305");
            Console.Write("Nhap so phan tu n: ");
            int n = int.Parse(Console.ReadLine());

            string[] arr = null;
            if (n > 0)
            {
                arr = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhap chuoi thu [{i+1}]: ");
                    arr[i] = Console.ReadLine();
                }
            }
            if (arr == null)
            {
                Console.WriteLine("So chuoi khac null va khac rong: 0");
                return;
            }

            int dem = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null && arr[i] != "")
                {
                    dem++;
                }
            }
            Console.WriteLine("So chuoi khac null va khac rong: " + dem);

        }
    }
}
