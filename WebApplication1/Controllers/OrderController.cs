using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class OrderController : Controller
    {
        /// <summary>
        /// 訂單管系系統首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //Models.OrderService orderService = new Models.OrderService();
            //var order = orderService.GetOrderById("111");
           // ViewBag.CustId = order.CustId;
            //ViewBag.Custname = order.CustName;

            
            return View();
        }
        /// <summary>
        /// 新增訂單畫面
        /// </summary>
        /// <returns></returns>

        public ActionResult Insertorder()
        {
            return View();     
        }

        /// <summary>
        /// 新增訂單存檔的Action
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost()]
        public ActionResult Insertorder(Models.Order order)
        {
            ViewBag.Desc1 = "我是viewbag";
            ViewData["Desc2"] = "我是viewdata";
            TempData["Desc3"] = "我是TempData";

            return RedirectToAction("index");//成功後轉到首頁
        }
        [HttpGet()]
        public JsonResult TestJson()
        {
            //var result = new Models.Order();
            //result.CustId = "GSS";
            //result.CustName = "叡揚資訊";
            var result=new Models.Order() {CustId = "GSS",CustName = "叡揚資訊"};
            return this.Json(result,JsonRequestBehavior.AllowGet);
        }
    }
}