namespace Vidly.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    using Vidly.Models;
    using Vidly.ViewModel;

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
        public ActionResult WineList()
        {
            var wineList = new List<Wine> { new Wine { Name = "Kadarka" }, new Wine { Name = "Hessa" } };


            return this.View(wineList);
        }
    }
}