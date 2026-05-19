using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Tasks
    {
        public static void Main()
        {
            Console.WriteLine("Main Thread " + Thread.CurrentThread.ManagedThreadId + " started"); 

            Task<Student> task1 = Task.Run(() =>
            {
                Student student = new Student()
                {
                    Id = 101,
                    Name = "Tejesh"
                };

                return student;
            });

            Console.WriteLine(task1.Result.Id+ "name of the student " + task1.Result.Name);
            Console.WriteLine("Main Thread "+Thread.CurrentThread.ManagedThreadId+ " competed");
        }

        public static int Count(int max)
        {
            int sum = 0;
            Console.WriteLine("Child Thread " + Thread.CurrentThread.ManagedThreadId + " Started");
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("count value is " + i);
                sum += i;
            }
            Console.WriteLine("Child thread" + Thread.CurrentThread.ManagedThreadId + " Completed");
            return sum;
        }



        public static void print()
        {
            Console.WriteLine("Child Thread "+Thread.CurrentThread.ManagedThreadId + " Started");
            for (int i=0;i<5;i++)
            {
                Console.WriteLine("count value is " + i);
            }
            Console.WriteLine("Child thread"+Thread.CurrentThread.ManagedThreadId+" Completed");
        }
    }
}
