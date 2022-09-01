﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Routing
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e){
            RouteTable.Routes.MapPageRoute(
                "CustomerOrder",
                "Customer/{id}/Order",
                "~/Order/CustomerOrder.aspx");

            RouteTable.Routes.MapPageRoute(
                "CustomerBill",
                "Customer/{id}/Bill",
                "~/Bill/CustomerBill.aspx");
        }
    }
}