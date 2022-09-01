using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Routing.Order{
    public partial class CustomerOrder : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){
            //capturing the current URL
            string[] url = HttpContext.Current.Request.Url.AbsolutePath.Split('/');

            ClsCustomerOrder Order = new ClsCustomerOrder();
            Response.Write("Order by the customer is : " + Order.GetOrder(Convert.ToInt32(url[2])));
        }
    }

    public class ClsCustomerOrder{
        Dictionary<int, string> Order = new Dictionary<int, string>();
        public ClsCustomerOrder(){
            Order.Add(1, "C# Book");
            Order.Add(2, "Java Book");
            Order.Add(3, "PHP Book");
        }
        public string GetOrder(int id){
            return Order[id];
        }
    }
}