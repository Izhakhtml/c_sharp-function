// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace functionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            //Print();
            //PrintName();
            //GetString("izhak lijalem");
            //GetNumber(90);
            //GetNumberUser();
            //GetUserNumber();
            //PrintFiveTimes(int.Parse(Console.ReadLine()));
            //GetNumberPrint(int.Parse(Console.ReadLine()));
            //GetNumberAndString(int.Parse(Console.ReadLine()), Console.ReadLine());
            // Dog dog1 = new Dog("rex","boxer",true,23);
            //Cat cat1 = new Cat("cat", "white", true,12);
            //cat1.getDetails();
            //cat1.getDetails();
            //Console.WriteLine(GetSumOfFourNumbers(50,80,90,60));
            //Console.WriteLine(GetSumDivided(GetSumOfFourNumbers(50, 80, 90, 60)));
            //replaceValues();
            //GetUserNumbersAll();
            //GetTwoArgumets();
            //GetNumberPlus();
            //Console.WriteLine(GetEnlarge());
            //Console.WriteLine(GetRadiusNumber(23));
            //UpNumbers();
            //IntegerNum();
            //GetNumbersThreeJump();
            //GetFiveNumbers();
            //GetNumbersCalaulateMinMax();
            //NumbersFromUserss();
            //GetNumberAndSeprate();
            //GetRandomNumber();
            /////////////////////////////////////
            //Student student = new Student("izhak","t",3);
            //student.CheckAge();
            //Lecturer student = new Lecturer("izhak","t",1996,true);
            //Console.WriteLine(student.PrintAllDetails());
            //student.CheckYearBierthAndCar();
            //GetTriangular();


        }
        /// exe 1
        static void Print()
        {
            Console.WriteLine("hello there");
        }
        /// exe 2
        static void PrintName()
        {
            Console.WriteLine("izhak");
        }
        /// exe 3
        static void GetString(string str)
        {
            Console.WriteLine(str);
        }
        /// exe 4
        static void GetNumber(int num)
        {
            Console.WriteLine(num);
        }
        /// exe 5
        static void GetNumberUser() 
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);
        }
        /// exe 6
        static void GetUserNumber()
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 25)
            {
                Console.WriteLine("HI");
            }
            else
            {
                Console.WriteLine("BYE");
            }
        }
        /// exe 7
        static void PrintFiveTimes(int num)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(num);
                i++;
            }
        }
        /// exe 8
        static void GetNumberPrint(int num)
        {
            int i = 0;
            while (i < num)
            {
                Console.WriteLine(num);
                i++;
            }
        }
        /// exe 9
        static void GetNumberAndString(int num,string str)
        {
            int i = 0;
            while (i < num)
            {
                Console.WriteLine(str+" "+i);
                i++;
            }
        }
        /// exe 10
        static int GetSumOfFourNumbers(int num,int num2,int num3,int num4) 
        {
            return  num + num2 + num3 + num4;
        }
        static int GetSumDivided(int num)
        {
            int sum = num;
            int avg = sum / 4;
            return avg;
        }
        /// exe 11
        static void CalculateWidthRigth(int width,int heigth) {
            Console.WriteLine(width * heigth);
        }

        /// exe 12
        static void replaceValues()
        {
            int num = 1;
            int num2 = 2;
            int num3 = 0;
            Console.WriteLine(num+" "+num2);
            if (num < num2)
            {
                num3 = num2;
                num2 = num; 
                num = num3;
                Console.WriteLine(num+" "+num2);

            }
         }
         /// exe 13
         static void GetUserNumbersAll()
            {
                int i = 0;
                int sum = 1;
                while (i < 3)
                {
                    int userNumber = int.Parse(Console.ReadLine());
                    sum *= userNumber;
                    i++;
                }
                Console.WriteLine(sum);
          }
         /// exe 14
         static void GetTwoArgumets()
         {
            float first = float.Parse(Console.ReadLine());
            float second = float.Parse(Console.ReadLine());
            float result = first / second;
            Console.WriteLine(result);
         }
         /// exe 15
         static int GetEnlarge()
         {
            int num = int.Parse(Console.ReadLine());
            num++;
            return num;
         }
         /// exe 16
         static void GetNumberPlus()
         {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num*=3);
         }
         /// exe 17
         static string GetRadiusNumber(double radius)
         {
            double width = radius * 2 * 3.14;
            double heigth = 3.14 * radius * radius;
            return $"Area:{width} Scope:{heigth}";
         }
         /// exe 18
         static void UpNumbers()
         {
            int num = 0;
            while (num < 100)
            {
                Console.WriteLine(num);
                num++;
            }
         }
         /// exe 19
         static void IntegerNum()
         {
            int i = 0;
            while (i < 50)
            {
                if (i % 2==0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
         }
         /// exe 20
         static void GetNumbersThreeJump()
         {
            int i = 0;
            while (i < 50)
            {
                if (i % 3 == 1)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
         }
         /// exe 21
         static void GetFiveNumbers()
         {
            int i = 0;
            int sum = 0;
            int avg = 0;
            while (i < 5)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
                avg = sum / 5;
                i++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(avg);

         }
         // exe 22
         static void GetNumbersCalaulateMinMax()
         {
            double i = 0;
            double min = double.MaxValue;
            double max = double.MinValue;
            while (i<5)
            {
            double numbers = double.Parse(Console.ReadLine());
            min = Math.Min(min,numbers);
            max = Math.Max(max,numbers);
            i++;
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
         }
         // exe 23
         static void NumbersFromUserss()
         {
            int number = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            int i = 0;
            while (number > 0)
            {
            number = int.Parse(Console.ReadLine());
            max = Math.Max(max,number);
            min = Math.Min(min,number);
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
         }
         // exe 24
         static void GetNumberAndSeprate()
         {
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < num)
            {
                int number = num % 10;
                Console.WriteLine(number);
                int cal = num / 10 - number / 10;
                num = cal;
            }
         }
         // exe 25
         static void GetRandomNumber()
         {
            Random math = new Random();
            int num = 45;
            double randomNum = math.Next(0, 100);
            int numberUser = int.Parse(Console.ReadLine());
            int i = 0;
            while (randomNum != numberUser)
            {
                if (randomNum < numberUser)
                {
                    Console.WriteLine("bigger");
                    numberUser = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("lower");
                    numberUser = int.Parse(Console.ReadLine());
                }
                if (numberUser == randomNum)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("very well");
                }
                i++;
            }
         }
         // exe 26
         static void GetNumberReturnPlus()
         {
                int width = int.Parse(Console.ReadLine());
                int heigth = int.Parse(Console.ReadLine());

                for (int i = 0; i < heigth; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
         }
         // exe 27
         static void GetTriangular()
         {
                int userNumber = int.Parse(Console.ReadLine());
                string space = "";
                for(int i = 0; i < userNumber; i++)
                {
                    space += "*";
                    Console.WriteLine(space);
                }
         }
    }
}
