using System;
using System.Linq;
using StudentCRUDApp.Data;
using StudentCRUDApp.Models;

class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            // CREATE
            var student = new Student
            {
                Name = "Shravani",
                Age = 21,
                Course = "CSE-AIML"
            };

            context.Students.Add(student);
            context.SaveChanges();
            Console.WriteLine("✅ Student Added!");

            // READ
            Console.WriteLine("\n--- Student List ---");
            var students = context.Students.ToList();

            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id} | {s.Name} | {s.Age} | {s.Course}");
            }

            // UPDATE
            var firstStudent = context.Students.FirstOrDefault();

            if (firstStudent != null)
            {
                firstStudent.Name = "Updated Shravani";
                context.SaveChanges();
                Console.WriteLine("\n✅ Student Updated!");
            }

            // READ AFTER UPDATE
            Console.WriteLine("\n--- After Update ---");
            foreach (var s in context.Students.ToList())
            {
                Console.WriteLine($"{s.Id} | {s.Name}");
            }

            // DELETE
            var deleteStudent = context.Students.FirstOrDefault();

            if (deleteStudent != null)
            {
                context.Students.Remove(deleteStudent);
                context.SaveChanges();
                Console.WriteLine("\n✅ Student Deleted!");
            }

            // FINAL READ
            Console.WriteLine("\n--- Final Data ---");
            var finalList = context.Students.ToList();

            if (finalList.Count == 0)
            {
                Console.WriteLine("No students found.");
            }
            else
            {
                foreach (var s in finalList)
                {
                    Console.WriteLine($"{s.Id} | {s.Name}");
                }
            }
        }
    }
}