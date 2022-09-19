using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InProcSessionExample
{
    public partial class UserDetail : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){
            try{
                string name = Session["Name"].ToString();
                Response.Write(string.Format("User name is :{0}", name));
            }
            catch (NullReferenceException ex){
                Response.Write(ex.Message + " Becasue Session doesn't exist");
            }
        }
    }
}