using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_sach
{
    class Textbook : Book
    {
        String book_status;
        public Textbook()
        {
            Console.InputEncoding = Encoding.Unicode;
            this.book_status = "Mới";
        }
        public Textbook(String book_status)
        {
            this.book_status = book_status;
        }
        public String input_textbook()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập tình trạng sách (Moi hoặc Cu): ");
            this.book_status = Console.ReadLine();
            return this.book_status;
        }
        public double caculate()
        {
            Double total = 0;

            if (String.Compare(input_textbook(), "Moi", true) == 0)
                total = (Double)(this.amount * this.amount);
            if (String.Compare(input_textbook(), "Cu", true) == 0)
                total = (Double)(this.amount * this.unit_price / 2);
            return total;
        }
        public void output_textbook()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Sách có mã {0} có giá: {1}", this.keybook, this.caculate());
        }
    }
}
