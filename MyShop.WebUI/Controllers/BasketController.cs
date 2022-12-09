using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MyShop.Core.Contracts;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace MyShop.WebUI.Controllers
{
    public class BasketController : Controller
    {
        private IHttpContextAccessor Accessor;
        IBasketService basketService;



        public BasketController (IBasketService BasketService)
        {
            this.basketService = BasketService;
        }


        public IActionResult Index()
        {
            var model = "basketService.GetBasketItems - " + HttpContext.Request;
            return View(model);
        }

        public ActionResult AddToBasket(string Id)
        {

            //basketService.AddToBasket(this.HttpContext, Id);
            HttpContext.(basketService.AddToBasket, Id);
            return View();
        }

        public ActionResult RemoveBasket(string Id)
        {
            basketService.RemoveFromBasket(this.HttpContext, Id);
            return View();
        }

        public PartialViewResult BasketSummary()
        {
            var basketSummary = "basketService.GetBasketSummary -" +HttpContext.Request;
            return PartialView(basketSummary);
        }
    }
}
