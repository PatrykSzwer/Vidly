namespace Vidly.Controllers
{
    using System.Web.Mvc;
    using Vidly.Models;

    /// <summary>
    /// The movies controller.
    /// </summary>
    public class MoviesController : Controller
    {
        /// <summary>
        /// The index. GET: Movies/random
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Random()
        {
            var movie = new Movie { Name = "I Am Legend" };

            return View(movie);
        }
    }
}