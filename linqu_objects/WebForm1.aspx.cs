using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace linqu_objects
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 12, 14, 15, 17, 18, 21, 24, 30 };
            //select even numbers from an integer array
            var matches = from n in numbers where n % 2 == 0 select n;
                   foreach(int n in matches)
            {
                Response.Write(n + "<br>");  
                
            }
        }
    }
}
