using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertieStudent
{
    public class Student
    {
       

        private int _age;

        public int Age
        {
            get { return _age; }
            set {
                if (value >= 18 || value <=30)
                {
                    _age = value;
                }
                else { Console.WriteLine("Invalid range of age"); }
            }
        }


        private string _bankCard;

        public string BankCard
        {
            get { 
                string output = "***.***.***" + _bankCard.Substring(_bankCard.Length - 4);
                return output;
               // return _bankCard; 
            }
            set { _bankCard = value; }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Age = 35;

            Console.WriteLine("Give your bankCard in");
            student.BankCard = Console.ReadLine(); 
            Console.WriteLine($"Your Banck Cad number{student.BankCard}");

        }
    }
}
