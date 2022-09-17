using System.ComponentModel.DataAnnotations;

namespace _2019_2020.Models
{
    public class CreateOrderModel
    {
        [Required]
        [Display(Name = "Customer Name")]
        public int Customer { get; set; }

        [Required]
        [Display(Name = "Product List")]
        public int Product { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        public string OrderDate { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        [Display(Name = "Quantity")]
        public int quantity { get; set; }

    }
}
