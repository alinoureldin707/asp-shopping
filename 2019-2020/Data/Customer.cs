using System.Collections.Generic;

namespace _2019_2020.Data
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string BDate { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
