using System;
using System.Collections.Generic;

namespace EntityCore.Models
{
    public partial class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string DeptName { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
