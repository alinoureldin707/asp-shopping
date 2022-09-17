using System.Collections.Generic;

namespace _2019_2020.Data
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string price { get; set; }

        public ICollection<Orders> Orders { get; set; }

    }
}
