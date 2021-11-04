using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        //api/animal/getAll
        [HttpGet("getAll")]
        public List<Animal> GetAllAnimals()
        {
            List<Animal> result = null;
            using(EFApiContext context = new EFApiContext())
            {
                result = context.Animals.ToList();
            }
            return result;
        }

        //api/animal/1
        [HttpGet("{id}")]
        public Animal GetAnimalById(int id)
        {
            Animal result = null;
            using(EFApiContext context = new EFApiContext())
            {
                result = context.Animals.Find(id);
            }
            return result;
        }

        //api/animal/getByName?name=John
        [HttpGet("getByName")]
        public Animal GetAnimalByName(string name)
        {
            Animal result = null;
            using(EFApiContext context = new EFApiContext())
            {
                result = context.Animals.ToList().Find(a => a.Name == name);
            }
            return result;
        }

        //api/animal/type/cat
        //api/animal/type/dog
        [HttpGet("type/{type}")]
        public List<Animal> GetAnimalsByType(string type)
        {
            List<Animal> result = null;
            using(EFApiContext context = new EFApiContext())
            {
                result = context.Animals.Where(a => a.Type == type).ToList();
            }
            return result;
        }

        //api/animal/Add?name=felony&type=cat&age=4

        [HttpPost("Add")]
        public Animal CreateAnimal(string name, string type, int age)
        {
            Animal newAnimal = new Animal();
            newAnimal.Name = name;
            newAnimal.Type = type;
            newAnimal.Age = age;
            using(EFApiContext context = new EFApiContext())
            {
                context.Animals.Add(newAnimal);
                context.SaveChanges();
            }

            return newAnimal;
        }

        //api/animal/delete/1
        [HttpDelete("delete/{id}")]
        public Animal DeleteById(int id)
        {
            Animal result = null;
            using(EFApiContext context = new EFApiContext())
            {
                result = context.Animals.Find(id);
                context.Animals.Remove(result);
                context.SaveChanges();
            }
            return result;
        }

    }
}
