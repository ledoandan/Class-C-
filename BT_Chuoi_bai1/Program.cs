using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ten: ");
            String hoten = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(hoten))
            {
                Console.WriteLine("Chuoi rong hoac khong hop le");
                return;
            }
            hoten = hoten.Trim();
            string[] words = hoten.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }

            string ketQua = string.Join(" ", words);
            Console.WriteLine("Ho ten sau chuan hoa: " + ketQua);
        }
    }
}
