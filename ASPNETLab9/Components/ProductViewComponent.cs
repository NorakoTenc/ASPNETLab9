using Microsoft.AspNetCore.Mvc;
using ASPNETLab9.Models;

namespace ASPNETLab9.Components
{
    public class ProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<Product> products)

        {
            return View("../Views/ProductTable.cshtml", products);

        }

    }

}   
