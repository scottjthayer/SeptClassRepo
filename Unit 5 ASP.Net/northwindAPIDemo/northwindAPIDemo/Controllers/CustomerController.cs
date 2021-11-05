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
    public class CustomerController : ControllerBase
    {
        [HttpGet()]
        public List<Customer> GetCustomers()
        {
            using(NorthwindContext context = new NorthwindContext())
            {
                return context.Customers.ToList();
            }
        }

        [HttpGet("{region}")]
        public List<Customer> GetCustomersByRegion(string region)
        {
            List<Customer> result = new List<Customer>();
            using(NorthwindContext context = new NorthwindContext())
            {
                result = context.Customers.Where(c => c.Region == region).ToList();
            }
            return result;
        }

        [HttpPost("add")]
        public Customer AddCustomer(string id, string companyname, string contactname, string contacttitle, string address, string city, string region, string postal, string country, string phone, string fax)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                Customer customer = new Customer()
                {
                    CustomerId = id,
                    CompanyName = companyname,
                    ContactName = contactname,
                    ContactTitle = contacttitle,
                    Address = address,
                    City = city,
                    Region = region,
                    PostalCode = postal,
                    Country = country,
                    Phone = phone,
                    Fax = fax
                };

                context.Customers.Add(customer);
                context.SaveChanges();
                return customer;
            }
        }
    }
}
