

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_4._2___OOP
{
    class CheckAgeWorker : Worker //derived class
    {
        public void Check(int WorkerAge)
        {
            CheckAge(WorkerAge);
        }

        private void CheckAge(int age)
        {
            if (age > 0 && age < 100)
            {
                SetAge(age);
            }
            else
            {
                Console.WriteLine("Your age is not in valable value!");
            }
        }
    }
}
