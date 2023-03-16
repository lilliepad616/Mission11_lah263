using Microsoft.AspNetCore.Mvc;
using Mission09_lah263.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_lah263.Components
{
    public class BasketSummaryViewComponent : ViewComponent {
        private Basket basket;
    public BasketSummaryViewComponent(Basket b)
    {
        basket = b;
    }
    public IViewComponentResult Invoke()
    {
        return View(basket);
    }

    }
}
