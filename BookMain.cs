using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_sach
{
    class BookMain
    {
        static void Main(string[] args)
        {
            int n;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập số lượng sách: ");
            n = Int32.Parse(Console.ReadLine());

            Textbook[] textbooks = new Textbook[n];
            for (int i = 0; i < n; i++)
            {
                textbooks[i] = new Textbook();
                textbooks[i].input_book();
                textbooks[i].output_book();
                textbooks[i].input_textbook();
                textbooks[i].caculate();
                textbooks[i].output_textbook();
            }
        }
    }
}
