using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.RollNumber = 2;
            ChangeRollNumber(ref s1);
            Console.WriteLine(s1.RollNumber);

            StudentStruct studentStruct = new StudentStruct();
            studentStruct.RN = 22;
            ChangeRollNumberForStruct(ref studentStruct);
            Console.WriteLine(studentStruct.RN);

            Console.ReadKey();
        }

        private static void ChangeRollNumber(ref Student student)
        {
            student.RollNumber = 3;
            student = new Student();
            student.RollNumber = 5;

        }

        private static void ChangeRollNumberForStruct(ref StudentStruct studentStructInput)
        {
            studentStructInput.RN = 33;
            studentStructInput = new StudentStruct();
            studentStructInput.RN = 55;
        }
    }

    public class Student
    {
        public int RollNumber { get; set; }
    }

    public struct StudentStruct
    {
        public int RN { get; set; }
    }

}
