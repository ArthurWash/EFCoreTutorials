using System;

namespace EFCoreTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {

                var std = new Student()
                {
                    Name = "Taylor"
                };

                context.Students.Add(std);
                context.SaveChanges();
            }
        }
    }
}
