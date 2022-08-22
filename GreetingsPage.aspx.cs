using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginForm
{
    public partial class GreetingsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //If an unauthorized user tries to get here, redirect to login page

            if (Session["username"] == null && Session["password"] == null)
            {

                Response.Redirect("LoginForm.aspx");

            }
            //else greet him
            else
            {
                greeting.InnerText = "Hello there, Mr. " + Session["username"];

            }

        }

        protected void Logout(object sender, EventArgs e)
        {
            //Upon logout, redirect & clear the session values
            Session.Clear();

            Response.Redirect("LoginForm.aspx");
        }
    }
}