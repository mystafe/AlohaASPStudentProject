using ASPPTraining1.Context;
using ASPPTraining1.Models.DTO;
using ASPPTraining1.Models.ORM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPPTraining1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        ASPContext _context;
        public CityController() { 
            _context= new ASPContext();
        }
        [HttpGet]
        public List<City> GetCities()
        {
            return _context.Cities.ToList();
        }

        [HttpGet("id")]
        public City GetCity(int id)
        {
            return _context.Cities.Find(id);
        }
        [HttpPost]
        public void PostCity(CityRegisterDTO model)
        {
            City city = new City()
            {
                 CountryId = model.CountryId,
                  Name = model.Name,                  
            };
            _context.Cities.Add(city);
            _context.SaveChanges();
        }
        [HttpDelete]
        public void Delete(int id)
        {
            City city = _context.Cities.Find(id);
            if (city != null)
            {
                _context.Cities.Remove(city);
                _context.SaveChanges();

            }
               
        }


    }
}
