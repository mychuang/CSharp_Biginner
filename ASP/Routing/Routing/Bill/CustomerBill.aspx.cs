using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Routing.Bill
{
    public partial class CustomerBill : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){
            string[] url = HttpContext.Current.Request.Url.AbsolutePath.Split('/');
            ClsCustomerBill Order = new ClsCustomerBill();
            Response.Write("Bill by the customer is : " + Order.GetOrder(Convert.ToInt32(url[2])));
        }
    }

    public class ClsCustomerBill{
        Dictionary<int, int> Order = new Dictionary<int, int>();
        public ClsCustomerBill(){
            Order.Add(1, 1000);
            Order.Add(2, 1500);
            Order.Add(3, 2400);
        }
        public int GetOrder(int id){
            return Order[id];
        }
    }
}