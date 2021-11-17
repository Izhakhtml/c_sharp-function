using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionConsole
{
    class Student
    {
        public string name;
        public string rome;
        public int age;
        public Student(string name,string rome,int age) 
        {
            this.name = name;
            this.rome = rome;
            this.age = age;
        } 
        string GetObject()
        {
            return (
                    $"NAME:{this.name} ROME:{this.rome} AGE:{this.age}");
        }
        public void GetFunction()
        {
             Console.WriteLine(this.GetObject());
        }
        public void CheckAge()
        {
            if (this.age <8) 
            {
                Console.WriteLine("BASIC");
            }
            else
            {
                Console.WriteLine($"NAME:{this.name} ROME:{this.rome} AGE:{this.age}");

            }
        }
    }
}
