using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;

            string resultat = "Hello " + firstName + " " + lastName;

            lblResult.Text = resultat;
            
            
            //string = alfa numeric value
            //int = numerical value
            //int i;
            //i = Convert.ToInt32("one");

            //double d = 3.5;
            //int i = (int)d; //truncate

            //lblResult.Text = i.ToString();
            /*
            string s = tbInput.Text;
            int i = int.Parse(s);
            int j = i + 1;
            lblResult.Text = j.ToString();
            */
        }
    }
}