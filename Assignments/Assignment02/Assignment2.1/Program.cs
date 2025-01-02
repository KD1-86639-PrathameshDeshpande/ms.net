using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using Assignment2._1;

namespace Assignment2._1
{

   public struct Student
    {
        private String _Name;
        private int _Age;
        private double _Marks;
        private char _Div;
        private int _Std;
        private bool _Gender;

        public bool Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }


        public int Std
        {
            get { return _Std; }
            set { _Std = value; }
        }


        public char Div
        {
            get { return _Div; }
            set { _Div = value; }
        }


        public double Marks
        {
            get { return _Marks; }
            set { _Marks = value; }
        }


        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }




        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        

        public Student(string name, int age, double marks, char div, int std, bool gender)
        {
            _Name = name;
            _Age = age;
            _Marks = marks;
            _Div = div;
            _Std = std;
            _Gender = gender;
        }
        public void accept()
        {
            Console.WriteLine("Enter Student Information");
            Console.WriteLine("Enter Name");
            _Name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            _Age = int.Parse(Console.ReadLine());
               
            Console.WriteLine("Enter Div");
            _Div = char.Parse(Console.ReadLine());


            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Enter Gender (1.Male, 2.Female)");
                int gender = int.Parse(Console.ReadLine());
                switch (gender)
                {
                    case 1:
                        _Gender = true;
                        flag=false;
                        break;
                       
                      case 2: 
                        _Gender = false;
                        flag=false;
                        break;
                    default:Console.WriteLine("Please enter only (M/F)");
                        break;

                }
            }
           
            
            
            Console.WriteLine("Enter Standard");
            _Std = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks");
            _Marks = int.Parse(Console.ReadLine());


        }

        public void getDetails()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine("Name: "+_Name);
            Console.WriteLine("Age:"+_Age);
            Console.WriteLine("Div:"+_Div);
            if (_Gender)
            {
                Console.WriteLine("Gender: Male");
            }
            else
            {
                Console.WriteLine("Gender: Female");
            }
            Console.WriteLine("Std: "+_Std);
            Console.WriteLine("Marks: "+_Marks);
        }


    }
}

    

    internal class Program
    {
        static void Main(string[] args)
        {
        Student student = new Student();
        student.accept();
        student.getDetails();
        


        }
    }

