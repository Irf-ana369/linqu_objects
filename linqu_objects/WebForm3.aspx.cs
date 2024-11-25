using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace linqu_objects
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source=DESKTOP-92KLAIN\SQLEXPRESS; initial catalog=linqU;integrated security=true");
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter("select * from Employee", con);
            adp.Fill(ds, "Emp");
            //select name and job of Employees
            var m = from emp in ds.Tables[0].AsEnumerable() select new { Name = emp.Field<string>("name"), Job = emp.Field<string>("job") };
            GridView1.DataSource = m;
            GridView1.DataBind();

            //find maximum of id.
            var n = (from emp in ds.Tables[0].AsEnumerable() select emp.Field<int>("id")).Max();
            Response.Write(n);
        }
    }
}