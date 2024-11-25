using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace linqu_objects
{
    [Table(Name = "Employee")]
    public class Employee
    {
        [Column(IsPrimaryKey =true)]
        public int Id { set; get; }
        [Column]
        public String Name { set; get; }
        [Column]
        public String Job { set; get; }
        [Column]
        public int Salary { set; get; }
    }
}