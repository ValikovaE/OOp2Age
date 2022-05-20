using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_4._2___OOP
{
    class Worker
    {
        private string name;
        private int age;
        private int salary;

        public string GetName()
        { return name; }
        public void SetName(string value)
        { name = value; }
        public int GetAge()
        { return age; }
        public void SetAge(int value)
        { age = value; }
        public int GetSalary()
        { return salary; }
        public void SetSalary(int value)
        { salary = value; }

    }
}
