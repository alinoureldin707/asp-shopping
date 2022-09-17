namespace _2019_2020.Data
{
    public class Orders
    {
        public int OrdersId { get; set; }
        public string OrderDate { get; set; }
        public int quantity { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
