using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuoi_bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            String chuoi = Console.ReadLine();

            if (chuoi == null)
            {
                Console.WriteLine("So tu: 0");
                return;
            }
            chuoi = chuoi.Trim();

            if (chuoi.Length == 0)
            {
                Console.WriteLine("So tu: 0");
                return;
            }

            string[] words = chuoi.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );

            Console.WriteLine("So tu: " + words.Length);
        }
    }
}
