using ASPPTraining1.Context;
using ASPPTraining1.Models.DTO;
using ASPPTraining1.Models.ORM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace ASPPTraining1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        ASPContext context;

        public CountryController()
        {
            context = new ASPContext();
        }
        [HttpGet]
        public List<Country> GetCountries()
        {
            return context.Countries.ToList();
        }
        [HttpGet("id")]
        public Country GetId(int id)
        {
            return context.Countries.Find(id);
        }
        [HttpPost]
        public void Post(CountryRegisterDTO model)
        {
            Country country=new Country();
            country.Name = model.Name;
            context.Countries.Add(country);
            context.SaveChanges();

        }
        [HttpDelete]
        public void Delete(int id)
        {
            Country country =context.Countries.Find(id);
            if (country != null)
            {
                context.Countries.Remove(country);
                context.SaveChanges();

            }
      
        }

    }
}
