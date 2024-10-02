using Interview.Service;
using Microsoft.AspNetCore.Mvc;

namespace Interview.Controllers
{
    public class OpeningBillController1 : Controller
    {
        private readonly IBill bill;
        public OpeningBillController1(IBill _bill)
        {
            this.bill = _bill;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Getdata(int id)
        {
            var li=bill.All(id);
            return Json(li);
        }
        public JsonResult SearchClients(string searchTerm)
        {
            var li=bill.SearchClients(searchTerm);
            return Json(li);
        }
        [HttpPost]
        public JsonResult UpdateItem(int id,int client,decimal capacity,decimal rate)
        {
            var li=bill.UpdateItem(id, client, capacity, rate);
            return Json(li);
        }
    }
}
