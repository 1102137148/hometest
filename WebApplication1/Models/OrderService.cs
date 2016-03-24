using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    /// <summary>
    /// 訂單的服務
    /// </summary>
    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        public void InserOrder(Models.Order order)
        {

        }

        /// <summary>
        /// 刪除訂單By Id
        /// </summary>
        public void DeleteOrderById(String id)
        {

        }

        /// <summary>
        /// 更新訂單
        /// </summary>
        public void UpdatwOrder(Models.Order order)
        {

        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <param name="id">訂單ID</param>
        /// <returns></returns>
        public Models.Order GetOrderById(string id)
        {
            Models.Order result = new Order();
            result.CustId = "GSS";
            result.CustName = "叡揚資訊";
            return result;
        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrders()
        {
            List<Models.Order> result = new List<Order>();
            result.Add(new Order() { CustId = "Gss", CustName = "叡揚資訊", EmpId = 1, EmpName = "王曉明", Orderdate = DateTime.Parse("2015/08/15") });
            result.Add(new Order() { CustId = "Abb", CustName = "呆呆資訊", EmpId = 2, EmpName = "王阿呆", Orderdate = DateTime.Parse("2015/10/25") });
            return result;
        }
    }
}