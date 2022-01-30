using System.Collections.Generic; 
using System.Web.Mvc;
using Theatrics.Models; 

namespace Theatrics.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListPeople()
        {
            return View(PeopleFromDataBase()); 
        }
        private static List<PersonModel> PeopleFromDataBase()
        { 
            List<PersonModel> r = new List<PersonModel>();
            r.Add(new PersonModel { FirstName = "Joe", LastName = "Shmoe", Age = 30 });
            r.Add(new PersonModel { FirstName = "Mick", LastName = "Smith", Age = 56 });
            r.Add(new PersonModel { FirstName = "Olive", LastName = "Connor", Age = 82 });
            return r; 
        }
    }
}