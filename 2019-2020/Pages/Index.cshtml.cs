using _2019_2020.Data;
using _2019_2020.Models;
using _2019_2020.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2019_2020.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CustomerService _customerService;
        public IndexModel(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [BindProperty]
        public CreateOrderModel order { get; set; }

        public List<SelectListItem> Items { get; set; }

        public async Task<IActionResult> OnGet()
        {
            List<Customer> customers = _customerService.GetCustomers();
            Items = null;
            foreach (Customer customer in customers)
            {
                Items.Add(new SelectListItem { Value = customer.CustomerId.ToString(), Text = customer.FullName.ToString() });
            }

            return Page();
        }
    }
}
