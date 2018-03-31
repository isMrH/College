using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBook.Model
{
    public class Carts
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookImage { get; set; }
        public int BookCount { get; set; }
        public double BookPrice { get; set; }
        public string UserId { get; set; }
    }
}
