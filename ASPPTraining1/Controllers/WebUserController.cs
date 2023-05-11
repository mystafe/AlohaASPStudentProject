using ASPPTraining1.Context;
using ASPPTraining1.Models.DTO;
using ASPPTraining1.Models.ORM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ASPPTraining1.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class WebUserController : Controller
    {
        ASPContext db;
        public WebUserController() 
        {
            db = new ASPContext();
        }

        [HttpGet]
        public List<WebUser> GetAll()
        {
            return db.WebUsers.Include(w=>w.Adress).ToList();
        }

        [HttpGet("{id}")]
        public WebUser Get(int id)
        {
            return db.WebUsers.Find(id);
        }

        [HttpPost()]
        public WebUser RegisterUser(WebUserRegisterDTO webuserdto)
        {
            WebUser webuser = new WebUser()
            {
                Firstname = webuserdto.Firstname,
                 Lastname = webuserdto.Lastname,
                 Email = webuserdto.Email,
                  Password = webuserdto.Password,
                  AdressId = webuserdto.AdressId
            };
            db.WebUsers.Add(webuser);
            db.SaveChanges();
            return webuser;
        }

        [HttpDelete]
        public void Delete(int id)
        {
            WebUser webUser  = db.WebUsers.Find(id);
            if (webUser != null)
            {
                db.WebUsers.Remove(webUser);
                db.SaveChanges();
            }
            
        }



    }
}
