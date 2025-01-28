using Microsoft.AspNetCore.Mvc;
using TestWithAzure.DataBaseConnection;
using TestWithAzure.Models;

namespace TestWithAzure.Controllers
{
    public class SampleController : Controller
    {
        private readonly AzureDatabaseContext db;

        public SampleController(AzureDatabaseContext db)
        {
                this.db = db;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserInformation UI)
        {
            db.Azure_UserInformation_Mst.Add(UI);
            db.SaveChanges();
            return RedirectToAction("Create");
        }
        //Testing Done
        public IActionResult GetAll()
        {
            List<UserInformation> UI = db.Azure_UserInformation_Mst.ToList();
            return View(UI);
        }
    }
}
