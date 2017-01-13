using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class WinesViewModel
    {
        public Wine Wine { get; set; }
        public List<Customer> Customers { get; set; }

        public WinesViewModel(Wine wine, List<Customer> customers)
        {
            this.Wine = wine;
            this.Customers = customers;
        }
    }
}
