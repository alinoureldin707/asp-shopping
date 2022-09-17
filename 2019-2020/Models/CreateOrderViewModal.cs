using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;

namespace _2019_2020.Models
{
    public class CreateOrderViewModal
    {
        public List<SelectListItem> customers { get; set; }

        public List<SelectListItem> products { get; set; }

    }
}
