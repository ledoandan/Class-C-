using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Mang_bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Le Doan Dan + 2415053122305");
            Console.Write("Nhap ho ten: ");
            string hoten = Console.ReadLine();
            if (hoten == null)
            {
                Console.WriteLine("Chuoi null, khong the tach");
                return;
            }

            hoten = hoten.Trim();

            string[] words = null;
            if (hoten.Length > 0)
            {
                words = hoten.Split(
                    new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries
                );
            }
            if (words == null)
            {
                Console.WriteLine("Mang ket qua null, khong in");
                return;
            }
            Console.WriteLine("Cac tu trong ho ten:");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
