using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Build1
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "ideliver" && TextBox2.Text == "ideliver")
            {
                Label3.Text = "Loggged in sucessfull";

            }
            else
            {
                Label3.Text = "Incorrect credentials";
            } 
        }
    }
}