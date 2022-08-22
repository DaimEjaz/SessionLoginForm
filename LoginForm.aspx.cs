using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginForm
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //If a logged-in user tries to get to login page, redirect back to greetings page

            if (Session["username"] != null && Session["password"] != null)
            {
                if (Session["username"].ToString() == "polar" && Session["password"].ToString() == "vezli")
                {
                    Response.Redirect("GreetingsPage.aspx");
                }
            }

        }

        protected void Login(object sender, EventArgs e)
        {
            //if the login info is right, save the user info in Session & go to greeting page

            if (username.Text == "polar" && password.Text == "vezli")
            {
                Session["username"] = username.Text;
                Session["password"] = password.Text;

                Response.Redirect("GreetingsPage.aspx");
            }
        }
    }
}