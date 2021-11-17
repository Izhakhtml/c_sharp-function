using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionConsole
{
    class Lecturer
    {
        public string fName;
        public string LName;
        public int yearBirth;
        public bool haveACar;
        public Lecturer(string fName,string LName,int yearBirth, bool haveACar) 
        {
            this.fName = fName;
            this.LName = LName;
            this.yearBirth = yearBirth;
            this.haveACar = haveACar;
        }
        string PrintAllDetails()
        {
            return $"first name:{this.fName} last name:{this.LName} age:{this.yearBirth} have a car:{this.haveACar}";
        }
        public void GetFunction()
        {
            Console.WriteLine(PrintAllDetails());
        }
        public void CheckYearBierthAndCar()
        {
            if (this.yearBirth>1995 && this.haveACar) 
            {
            Console.WriteLine($"first name:{this.fName} last name:{this.LName} age:{this.yearBirth} have a car:{this.haveACar}");
            }
        }
    }
}
