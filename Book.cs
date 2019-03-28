using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_sach
{
    class Book
    {
        protected String keybook;
        String date;
        protected Double unit_price;
        protected int amount;
        public Book()
        {
            this.keybook = "01";
            this.date = "28";
            this.unit_price = (Double)30000;
            this.amount = (int)30;
        }
        public Book(String keybook, String date, Double unit_price, int amount)
        {
            this.keybook = keybook;
            this.date = date;
            this.unit_price = unit_price;
            this.amount = amount;
        }
        public void input_book()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập mã sách: ");
            this.keybook = Console.ReadLine();
            Console.WriteLine("Ngày nhập: ");
            this.date = Console.ReadLine();
            Console.WriteLine("Đơn giá: ");
            this.unit_price = Double.Parse(Console.ReadLine());
            Console.WriteLine("Số lượng: ");
            this.amount = Int32.Parse(Console.ReadLine());
        }
        public void output_book()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("thông tin sách có mã {0}:\n\t Ngày nhập: {1}\t Đơn giá: {2}\t Số lượng: {3}", this.keybook, this.date, this.unit_price, this.amount);
        }
    }
}
