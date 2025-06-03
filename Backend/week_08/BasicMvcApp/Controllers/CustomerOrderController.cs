using Microsoft.AspNetCore.Mvc;
using BasicMvcApp.Models;


namespace BasicMvcApp.Controllers
{
    public class CustomerOrderController : Controller
    {
        public IActionResult Index()
        {

            // müşteri
            var müsteri = new Customer
            {
                Id = 1,
                FirstName = "Melih",
                LastName = "Can",
                Email = "melihcan@example.com"
            };

            // siparişler
            var siparis1 = new Order
            {
                Id = 1,
                ProductName = "Laptop",
                Quantity = 1,
                Price = 1500
            };

            var siparis2 = new Order
            {
                Id = 2,
                ProductName = "Mouse",
                Quantity = 1,
                Price = 20
            };

            var siparis3 = new Order
            {
                Id = 3,
                ProductName = "Monitör",
                Quantity = 2,
                Price = 50
            };




            // sipariş listesi ve siparişi veren kişi
            var siparisler = new CustomerOrderViewModel
            {
                Customers = müsteri,
                Orders = new List<Order> { siparis1, siparis2, siparis3 }
            };



            return View(siparisler);
        }

    }
}
