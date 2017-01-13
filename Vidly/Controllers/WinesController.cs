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

            return View(wine);
        }
    }
}