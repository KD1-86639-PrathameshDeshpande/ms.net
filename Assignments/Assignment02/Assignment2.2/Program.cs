using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    internal class Program
    {



        public static void CreateArray( Student[] students)
        {


            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                students[i].Accept();
            }


        }
        public static void DisplayStudents( Student[] students)
        {

            for (int i = 0; i < students.Length; i++)
            {
                students[i].GetDetails();
                Console.WriteLine();
            }
        }


        public static Student[] ReverseArray(Student[] students)
        {
            Student[] newArray = new Student[students.Length];
           
            for (int i = 0,j=students.Length-1 ; i < students.Length && j >= 0; i++,j--)
            {
                newArray[i] = students[j];
            }
            return newArray;
            

        }
      



        static void Main(string[] args)
        {
            Student student = new Student();
            

            Console.WriteLine("Enter Array size");
            int size =int.Parse( Console.ReadLine());
            Student[] students = new Student[size];
            CreateArray (students);
            Console.WriteLine();
            DisplayStudents(students);
            Console.WriteLine();

            

           
            Console.WriteLine();
            Console.WriteLine("Reversed Array");
            DisplayStudents(ReverseArray(students));


        }
    }
}
