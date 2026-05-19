using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Task2
    {
        public static void Main()
        {
            Console.WriteLine("Main Thread is started");

            Task<List<Student>> student = Task.Run( () =>
            {
                List<Student> student1=new List<Student>();
                Student s= new Student()
                {
                    Id = 101,
                    Name = "Tejesh"
                };

                student1.Add(s);

                return student1;
            });
            Console.WriteLine($"Student Name : {student.Result.First().Name} \n Student Id : {student.Result.First().Id}");
            Console.WriteLine("Main thread is completed");
            Console.Read();
        }

        public static int Sum(int max)
        {
            Console.WriteLine($"Child class running");
            int sum = 1;
            for(int i=1;i<=max;i++)
            {
                sum *= i;
                Console.WriteLine(i);
            }
            Console.WriteLine($"Child class Completed");

            return sum;
        }
    }

    public class  Student
    {
        public int Id { get; set; }

        public string Name { get; set; }    
    }
}
