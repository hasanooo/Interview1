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
    }
}
