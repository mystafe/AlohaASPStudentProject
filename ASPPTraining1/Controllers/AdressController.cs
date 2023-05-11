using ASPPTraining1.Context;
using ASPPTraining1.Models.DTO;
using ASPPTraining1.Models.ORM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace ASPPTraining1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdressController : Controller
    {

        ASPContext context;
        public AdressController()
        {
            context = new ASPContext();
        }
        [HttpGet]
        public List<Adress> GetAdresses()
        {
            return context.Adresses.Include(a=>a.City).ToList();
        }
        [HttpGet("id")]
        public Adress GetAdressById(int id)
        {
            return context.Adresses.Find(id);
        }
        [HttpPost]
        public void Post(AdressRegisterDTO model)
        {
            Adress adress=new Adress();
            adress.Name = model.Name;
            adress.Street = model.Street;
            adress.Description = model.Description;
            adress.CityId= model.CityId;
            context.Adresses.Add(adress);
            context.SaveChanges();
        }
        [HttpDelete]
        public void Delete(int id)
        {
            Adress adress=context.Adresses.Find(id);
            if (adress != null)
            {
                context.Adresses.Remove(adress);
                context.SaveChanges();
            }
        }
    }
}
