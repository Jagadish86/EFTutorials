using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
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
                // Insert
                //var std = new Student()
                //{
                //    StudentName = "Jagadish"                    
                //};

                // Update                
                //var std = context.Students.Where(x => x.StudentID.Equals(14)).FirstOrDefault();
                //std.StudentName = "Vijay";

                // Delete                
                //var std = context.Students.Where(x => x.StudentID.Equals(15)).FirstOrDefault();
                //context.Students.Remove(std);

                int statuscount = context.SaveChanges();

                if (statuscount > 0)
                {
                    Console.WriteLine("Record Updated Successfully");
                }
                else
                {
                    Console.WriteLine("Insert Record Failed");
                }

                // Fetch data from the database
                //Querying with LINQ to Entities 

                //var query = context.Students
                //                   .Where(s => s.StudentName == "Bill")
                //                   .FirstOrDefault<Student>();

                
                //Console.WriteLine(query.StudentID + query.StudentName );

                ////Querying with Object Services and Entity SQL
                //string sqlString = "SELECT VALUE st FROM SchoolDBEntities.Students " +
                //                    "AS st WHERE st.StudentName == 'Bill'";

                //var objctx = (context as IObjectContextAdapter).ObjectContext;

                //ObjectQuery<Student> student = objctx.CreateQuery<Student>(sqlString);
                //Student newStudent = student.First<Student>();

                //var anonymousResult = from s in context.Students
                //                      where s.StandardId == 1
                //                      select new
                //                      {
                //                          ID = s.StandardId,
                //                          Name = s.StudentName
                //                      };

                

                //foreach(var obj in anonymousResult)
                //{
                //    Console.WriteLine("ID: " + obj.ID + " Name: " + obj.Name);
                //}

                //var MethodSyntax = context.Students
                //                            .Where(x => x.StandardId == 1)
                //                            .Select(x => 
                //                            new 
                //                            { 
                //                                StudentID = x.StudentID, 
                //                                StudentName = x.StudentName 
                //                            });

                //foreach (var obj in MethodSyntax)
                //{
                //    Console.WriteLine("StudentID: " + obj.StudentID + " StudentName: " + obj.StudentName);
                //}

                //var stud1 = (from s in context.Students.Include("Standard")
                //             where s.StudentName == "Bill"
                //             select s).FirstOrDefault<Student>();


                //Console.WriteLine("ID: " + stud1.StudentID + " Name: " + stud1.StudentName + " "+ stud1.Standard.Description);

                //// disconnected new entity 
                //var studentNew = new Student() { StudentName = "Bill", StandardId =2 };

                //context.Entry(studentNew).State = studentNew.StudentID == 0 ? EntityState.Added : EntityState.Modified;

                //context.SaveChanges();

                //foreach (var entity in context.ChangeTracker.Entries())
                //{
                //    Console.WriteLine("{0}: {1}", entity.Entity.GetType().Name, entity.State);
                //}

                

                Console.ReadLine();
                
            }


            Console.WriteLine("Hello");
        }
    }
}
