using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace northwindAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet()]
        public List<Order> GetOrders()
        {
            using(NorthwindContext context = new NorthwindContext())
            {
                return context.Orders.ToList();
            } 
        }

        [HttpGet("{country}")]
        public List<Order> GetOrdersByShipCountry(string country)
        {
            List<Order> result = new List<Order>();
            using (NorthwindContext context = new NorthwindContext())
            {
                result = context.Orders.Where(o => o.ShipCountry == country).ToList();
            }
            return result;
        }
    }
}
