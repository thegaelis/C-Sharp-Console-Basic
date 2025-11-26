using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQ
{
    public class Program
    {
        
        class Student
        {
            private string Name;
            private DateTime DOB;
            private string Province;
            
            public Student()
            {
                this.Name = "Unknown Name";
                this.DOB  = new DateTime(1970,1,1);
                this.Province = "Unknown Province";
            }
            public Student(string name, DateTime dob, string province)
            {
                this.Name = name;
                this.DOB = dob;
                this.Province = province;
            }

            public string getName() => this.Name;
            public DateTime getDOB() => this.DOB;
            public string getProvince() => this.Province;

            public bool setName(string name)
            {
                if (name != null)
                {
                    this.Name = name;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            public bool setDOB(DateTime dob)
            {
                this.DOB = dob;
                return true;
            }
            public bool setProvince(string province)
            {
                this.Province = province;
                return true;
            }
            public string toString() => $"Student name: {this.Name}, student DOB: {this.DOB}, student province: {this.Province}";


        }

        class Classrooom
        {
            public ICollection<Student> Students {get; set;} = new List<Student> ();
            
            public int getNumberOfStudent() => Students.Count;
            public bool addStudent(Student student)
            {
                Students.Add(student);
                return true;
            }
            public bool removeStudent(string name)
            {
                // Construct a LINQ query
                // To use a LINQ query, data should be constructed in IEnumerable, IEnumerable<T> (these are interface of collection data types).

                // Flow:
                // - Data source: from (if you write as normal query, not use chained method)
                // - Filtering: Where()
                // - Projection: Select(), FirstOrDefault(), First(), Single(), SingleOrDefault()
                //      +Select(): Get the data that satisfied with filtering.
                //      +First(): Get the first element that satisfied with FIRST condition. If not, exception will be thrown
                //      +FirstOrDefault(): Same with First() but
                //  
                var result = Students.FirstOrDefault(student => student.getName() == name);
                // Where(student => student.Name = name), student => student.Name = name is a lambda expression
                if (result != null) // if the query returned as first or default.
                {
                    Students.Remove(result);
                    return true;
                }
                return false;
            }
            public bool searchStudent(string name)
            {
                var result = Students.Where(student => student.getName() == name);
                if (result.Any()) //if the data is avalable
                {
                    foreach (var student in result)
                    {
                        Console.WriteLine(student.toString());
                    }
                    return true;

                }
                return false;
                
            }
            public bool getAllStudentByProvince(string province)
            {
                //Order by: Default is ascending (OrderBy().), to use descending, use (OrderByDescending())
                var result =  Students.Where(student => student.getProvince() == province).OrderBy(student =>student.getDOB().Year);


                if (result.Any())
                {
                    foreach (var student in result)
                    {
                        Console.WriteLine(student.toString());
                    }
                }
                return false;
                
            }


            
        }


        static void Main(string[] args)
        {
            // Create classroom instance
            var classroom = new Classrooom();

            // Add students
            classroom.addStudent(new Student("Alice", new DateTime(2000, 5, 21), "Hanoi"));
            classroom.addStudent(new Student("Bob", new DateTime(1999, 8, 15), "Saigon"));
            classroom.addStudent(new Student("Charlie", new DateTime(2001, 12, 3), "Hanoi"));
            classroom.addStudent(new Student("Diana", new DateTime(2000, 7, 30), "Danang"));

            // Display number of students
            Console.WriteLine($"Number of students: {classroom.getNumberOfStudent()}");

            // Search for a student by name
            Console.WriteLine("Searching for 'Alice':");
            classroom.searchStudent("Alice");

            // Remove a student
            Console.WriteLine("Removing 'Bob':");
            classroom.removeStudent("Bob");
            Console.WriteLine($"Number of students after removal: {classroom.getNumberOfStudent()}");

            // Get all students by province
            Console.WriteLine("Students from Hanoi:");
            classroom.getAllStudentByProvince("Hanoi");
        }
    }
}