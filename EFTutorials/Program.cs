using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolDBEntities())
            {
                var std = new Student()
                {
                    StudentName = "Jagadish"                    
                };
                context.Students.Add(std);

                int statuscount = context.SaveChanges();

                if(statuscount > 0)
                {
                    Console.WriteLine("Record Inserted Successfully");
                }
                else
                {
                    Console.WriteLine("Insert Record Failed");
                }
            }


            Console.WriteLine("Hello");
        }
    }
}
