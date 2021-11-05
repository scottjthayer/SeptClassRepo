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
    public class ShipperController : ControllerBase
    {
        [HttpGet()]
        public List<Shipper> GetShippers()
        {
            using(NorthwindContext context = new NorthwindContext())
            {
                return context.Shippers.ToList();
            }
        }

        [HttpGet("{id}")]
        public Shipper FindShipperById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Shippers.ToList().Find(s => s.ShipperId == id);
            }
        }

        [HttpPost("add")]
        public Shipper AddShipper(string name, string phone)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                Shipper shipper = new Shipper()
                {
                    CompanyName = name,
                    Phone = phone                    
                };
                context.Shippers.Add(shipper);
                context.SaveChanges();
                return shipper;
            }
        }

        [HttpDelete("delete/{id}")]
        public string DeleteShipper(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                Shipper shipper = context.Shippers.ToList().Find(s => s.ShipperId == id);
                if (shipper == null)
                {
                    return "That shipper was not found"; 
                }
                else
                {
                    context.Shippers.Remove(shipper);
                    context.SaveChanges();
                    return "That shipper was deleted.";
                }
                
            }
        }
    }
}
