using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionConsole
{
    class Dog
    {
        public string name;
        public string breed;
        public bool isVacciend;
        public int age;
        public Dog(string name, string breed, bool isVacciend, int age) {
            this.name = name;
            this.breed = breed;
            this.isVacciend = isVacciend;
            this.age = age;
        }
        public string Print()
        {
        return $"name:{this.name} breed:{this.breed} bolean:{this.isVacciend} age:{this.age}";
        }
    }
}
