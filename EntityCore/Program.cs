using EntityCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCore
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Enter Student Name: ");
            ////string name = Console.ReadLine();
            //string name = "Shubham";
            ////Console.WriteLine("Enter Department No");
            //int deptNo = 10;
            ////int deptNo = int.Parse(Console.ReadLine());
            ////Console.WriteLine("Enter Email");
            ////string email = Console.ReadLine();
            //string email = "s@g.com";
            ////Console.WriteLine("Enter Mobile");
            ////string mob = Console.ReadLine();
            //string mob = "9988766577";
            //Employee ob = new Employee()
            //{
            //    DeptNo = deptNo,
            //    Email = email,
            //    EmpId = string.Format("{0}", DateTime.Now.Millisecond.ToString()),
            //    RegDate = DateTime.Now,
            //    EmpName = name,
            //    Mobile = mob
            //};

            //testContext context = new testContext();
            //context.Employee.Add(ob);
            //context.SaveChanges();
            //Console.WriteLine("Data inserted successfully");
            //context.Dispose();
            //Console.ReadKey();

            var context = new testContext();
            //var data = context.Employee.Where(x => x.DeptNo == 10)
            //           .Include(x => x.DeptNoNavigation)
            //           .ToList();
            //foreach(var dt in data)
            //{
            //    Console.WriteLine(string.Format("Id : {0}", dt.EmpId));
            //    Console.WriteLine(string.Format("Employee : {0}", dt.EmpName));
            //    Console.WriteLine(string.Format("Email : {0}", dt.Email));
            //    Console.WriteLine(string.Format("Mobile : {0}", dt.Mobile));
            //    Console.WriteLine(string.Format("Department : {0}", dt.DeptNoNavigation.DeptName));
            //    Console.WriteLine("--------------------------------------------------------------------");
            //}
            //Console.ReadKey();
            //var data = context.Employee.Where(x => x.EmpName == "Shub").FirstOrDefault();
            //data.Email = "shub@gmail.com";
            //context.SaveChanges();
            //Console.WriteLine("Changes Updated");
            //Console.ReadKey();

            var data = new Employee()
            {
                EmpId = "1003",
                DeptNo = 10,
                EmpName = "Shub",
                Mobile = "9900887908",
                RegDate = DateTime.Now,
                Email = "shub.th@gmail.com"
            };

            context.Update(data);
            context.SaveChanges();
            Console.WriteLine("Changes Updated");
            Console.ReadKey();


        }
    }
}
