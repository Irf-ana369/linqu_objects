using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace linqu_objects
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Emp> Employees = new List<Emp>();

            Employees.Add(new Emp { Name = "Jobin", Age = 22, Salary = 24000 });
            Employees.Add(new Emp { Name = "Ajith", Age = 23, Salary = 26000 });
            Employees.Add(new Emp { Name = "Sibin", Age = 24, Salary = 25000 });
            Employees.Add(new Emp { Name = "Elju", Age = 24, Salary = 22000 });
            Employees.Add(new Emp { Name = "Shiju", Age = 22, Salary = 20000 });
            Employees.Add(new Emp { Name = "Sreelakshmi", Age = 22, Salary = 25000 });
            Employees.Add(new Emp { Name = "Sangeeth", Age = 22, Salary = 25000 });
            Employees.Add(new Emp { Name = "Roby", Age = 22, Salary = 25000 });
            Employees.Add(new Emp { Name = "Suresh", Age = 23, Salary = 21000 });
            Employees.Add(new Emp { Name = "soumya", Age = 24, Salary = 25000 });
            Employees.Add(new Emp { Name = "Nisha", Age = 24, Salary = 28000 });
            Employees.Add(new Emp { Name = "Eldho", Age = 22, Salary = 25000 });
            Employees.Add(new Emp { Name = "Johnson", Age = 24, Salary = 26500 });
            //select employees have an age grater than 22 and salary grater than 22000

            //var match = from emp in Employees where emp.Age > 22 && emp.Salary > 22000 select emp;
            //GridView1.DataSource = match;
            //GridView1.DataBind();

            //select employee Name
            //var match1 = from emp in Employees select emp.Name;
            //GridView1.DataSource = match1;
            //GridView1.DataBind();

            //select Employee Name and salary
            //var match = from emp in Employees
            //           select new
            //           {
            //               Name_of_Employee = emp.Name,
            //               emp.Salary
            //           };
            //GridView1.DataSource = match;
            //GridView1.DataBind();

            ////select distinct ages
            //var match = (from emp in Employees select emp.Age).Distinct();
            //GridView1.DataSource = match;
            //GridView1.DataBind();

            //    //select Employees whose name starts with s and have an ages > 22
            //    var match = from emp in Employees where emp.Name.StartsWith("S") && emp.Age > 22 select emp;
            //    GridView1.DataSource = match;
            //    GridView1.DataBind();

            //static bool TestEmployee(Emp em)
            //{
            //    return em.Name.StartsWith("S");
            //}
            //Using the order by clause.within the query expression.
            var match = from emp in Employees orderby emp.Name select emp;
            GridView1.DataSource = match;
            GridView1.DataBind();

            var match1 = from emp in Employees orderby emp.Name descending select emp;
            GridView1.DataSource = match1;
            GridView1.DataBind();
        }

    }
}