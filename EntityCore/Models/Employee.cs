using System;
using System.Collections.Generic;

namespace EntityCore.Models
{
    public partial class Employee
    {
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public int? DeptNo { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime? RegDate { get; set; }

        public Department DeptNoNavigation { get; set; }
    }
}
