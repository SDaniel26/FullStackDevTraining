using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicMath
{
    public partial class Math : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            int i = 7 + 3 * 5;

            lblRezultat.Text = i.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // concatenation
            string fname = TextBox1.Text;
            string lname = TextBox2.Text;

            Label1.Text = "your name is " + fname + " " + lname;
        }
    }
}