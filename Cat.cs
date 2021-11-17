using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionConsole
{
    class Cat
    {
        public string name;
        public string breed;
        public bool isWhite;
        public int age;
        public Cat(string name,string breed,bool isWhite, int age) {
            this.name = name;
            this.breed = breed;
            this.isWhite = isWhite;
            this.age = age;
        }
       string PrintDetails()
        {
         return $"name:{this.name} breed:{this.breed} isWhite:{this.isWhite} age:{this.age}";
        }
        public void getDetails()
        {
            Console.WriteLine(this.PrintDetails());
        }
    }
}
