using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Mang_bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Le Doan Dan + 2415053122305");
            Console.Write("Nhap cau: ");
            string s = Console.ReadLine();
            if (s == null)
            {
                Console.WriteLine("Chuoi null, khong xu ly");
                return;
            }

            s = s.Trim();
            if (s.Length == 0)
            {
                Console.WriteLine("Khong co tu nao");
                return;
            }

            string[] words = s.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );
            string tuDaiNhat = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > tuDaiNhat.Length)
                {
                    tuDaiNhat = words[i];
                }
            }
            Console.WriteLine("Tu dai nhat: " + tuDaiNhat);
            Console.WriteLine("Do dai: " + tuDaiNhat.Length);
        }
    }
}
