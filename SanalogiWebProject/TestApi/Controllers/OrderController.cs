using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using X.PagedList;

namespace TestApi.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index(int pageNumber = 1)
        {

            // apimize istek atıyoruz.
            // veritabanımızdakı listeyi donderiyoruz.

            IEnumerable<Order> orders = null;
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://localhost:5117/api/");

                var response = client.GetAsync("Order");
                response.Wait();

                var result = response.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadFromJsonAsync<IEnumerable<Order>>();
                    readTask.Wait();

                    orders = readTask.Result.ToPagedList(pageNumber, 5); 
                    // Pagination eklendi.

                  
                }
                else
                {
                    orders = Enumerable.Empty<Order>();
                    ModelState.AddModelError(String.Empty, "Server error. Please contact administrator.");
                }

            }
            return View(orders);
        }

        public ActionResult CreateOrder()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult CreateOrder(Order data)
        {

            //Postumuzda ise apimize post yapabılmek icin
            //json formatında order gonderiyoruz. 

            
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5117/api/");
              
                    client.DefaultRequestHeaders.Clear();
                //HTTP POST
                    var postTask = client.PostAsJsonAsync<Order>("order", data);
                    postTask.Wait();

                    var result = postTask.Result;
                //ViewBag.msg= result.Content.Headers.ToString();
                if (result.IsSuccessStatusCode)
                    {
                   
                    return Json(new { redirectToUrl=Url.Action("Index","Order")});
                    }
                else
                {
                    
                    return Json(new { redirectToUrl = Url.Action("Index", "Order") });
                }
                   
                }



            return Json(new { redirectToUrl = Url.Action("Index", "Order") });
        }
    }

}
