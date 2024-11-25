using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace linqu_objects
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataContext dc = new DataContext(@"data source=DESKTOP-92KLAIN\SQLEXPRESS; initial catalog=linqU;integrated security=true");
                Table<Employee> employees = dc.GetTable<Employee>();
                //select employee who have salary grater than 25000
                var m1 = from emp in employees where emp.Salary > 3333 select emp;
                GridView1.DataSource = m1;
                GridView1.DataBind();

                //select name and job from the table..
                var m = from emp in employees select new { Name = emp.Name, Id = emp.Id };
                DropDownList1.DataSource = m;
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source=DESKTOP-92KLAIN\SQLEXPRESS; initial catalog=linqU;integrated security=true");
            Table<Employee> employees = dc.GetTable<Employee>();
            var m = from emp in employees where emp.Id == Convert.ToInt32(DropDownList1.SelectedItem.Value) select emp;
            GridView1.DataSource = m;
            GridView1.DataBind();

            foreach(Employee em in m)
            {
                TextBox1.Text = em.Id.ToString();
                TextBox2.Text = em.Name;
                TextBox3.Text = em.Job;
                TextBox4.Text = em.Salary.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source=DESKTOP-92KLAIN\SQLEXPRESS; initial catalog=linqU;integrated security=true");
            Table<Employee> employees = dc.GetTable<Employee>();

            Employee emp = new Employee { Id = Convert.ToInt32(TextBox1.Text), Name = TextBox2.Text, Job = TextBox3.Text, Salary = Convert.ToInt32(TextBox4.Text) };
            employees.InsertOnSubmit(emp);
            dc.SubmitChanges();

            GridView1.DataSource = employees;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source=DESKTOP-92KLAIN\SQLEXPRESS; initial catalog=linqU;integrated security=true");
            Table<Employee> employees = dc.GetTable<Employee>();

            Employee em = (from emp in employees where emp.Id == (Convert.ToInt32(DropDownList1.SelectedItem.Value)) select emp).First<Employee>();
            employees.DeleteOnSubmit(em);
            dc.SubmitChanges();

            GridView1.DataSource = employees;
            GridView1.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source=DESKTOP-92KLAIN\SQLEXPRESS; initial catalog=linqU;integrated security=true");
            Table<Employee> employees = dc.GetTable<Employee>();

            Employee em = (from emp in employees where emp.Id == (Convert.ToInt32(DropDownList1.SelectedItem.Value)) select emp).First<Employee>();
            em.Job = TextBox3.Text;
            em.Name = TextBox2.Text;
            em.Salary = Convert.ToInt32(TextBox4.Text);
            dc.SubmitChanges();

            GridView1.DataSource = employees;
            GridView1.DataBind();
        }
    }
}