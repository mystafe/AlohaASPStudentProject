using ASPPTraining1.Context;
using ASPPTraining1.Models.DTO;
using ASPPTraining1.Models.ORM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPPTraining1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UniversityController : Controller
    {
        ASPContext context;
        public UniversityController() { 
            context = new ASPContext();
        }
        [HttpGet]
        public List<University> GetUniversities()

        {
            return context.Universities.Include(u=>u.City.Country).ToList();
        }
        [HttpGet("id")]
        public University GetById(int id)
        {
            return context.Universities.Find(id);
        }
        [HttpPost]
        public void Post(UniversityRegisterDTO model) {
        
            University university=new University();
            university.Name=model.Name;
            university.CityId=model.CityId;
            context.Universities.Add(university);
            context.SaveChanges();
        }
        [HttpDelete]
        public void Delete(int id)
        {

            University university = context.Universities.Find(id);
            if (university != null)
            {
                context.Universities.Remove(university);
                context.SaveChanges();
            }
        }
    }
}
