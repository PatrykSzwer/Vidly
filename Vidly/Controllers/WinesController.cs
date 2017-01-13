using System.Collections.Generic;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    using System.Web.Mvc;
    using Vidly.Models;

    /// <summary>
    /// The wines controller.
    /// </summary>
    public class WinesController : Controller
    {
        /// <summary>
        /// The index. GET: Wines/random
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Index()
        {
            var wine = new Wine { Name = "Kadarka" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Patryk"},
                new Customer {Name = "Adam"}
            };

            var viewModel = new WinesViewModel(wine, customers);

            return View(viewModel);
        }
    }
}