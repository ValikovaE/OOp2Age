using System;
namespace C_Sharp_Lesson_4._2___OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Worker worker1 = new Worker();
            Worker worker2 = new Worker();
            worker1.SetName("John");
            worker1.SetAge(25);
            worker1.SetSalary(1000);
            worker2.SetName("Sam");
            worker2.SetAge(26);
            worker2.SetSalary(2000);
            Console.WriteLine("The sum of John's and Sam's salaries: " + (worker1.GetSalary() + worker2.GetSalary()));
            Console.WriteLine("The sum of John's and Sam's ages: " + (worker1.GetAge() + worker2.GetAge()));
            CheckAgeWorker worker3 = new CheckAgeWorker();
            worker3.SetName("Mark");
            worker3.SetAge(11);
            worker3.Check(1110);
            worker3.GetAge();
            worker3.SetSalary(3000);
            Console.WriteLine("Name: " + worker3.GetName() + ", Age: " + worker3.GetAge());
        }
    }
}
