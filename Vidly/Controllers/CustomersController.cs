namespace Vidly.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Vidly.Models;

    /// <summary>
    /// The customers controller.
    /// </summary>
    public class CustomersController : Controller
    {
        /// <summary>
        /// The customers.
        /// </summary>
        private readonly List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Patryk" },
                new Customer { Name = "Magdalena" }
            };

        /// <summary>
        /// The customer list.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult CustomerList()
        {

            return this.View(this.customers);
        }

        /// <summary>
        /// The customer details.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult CustomerDetails(int id)
        {
            return this.View(this.customers[id]);
        }
    }
}