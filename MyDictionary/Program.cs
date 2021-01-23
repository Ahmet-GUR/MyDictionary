using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();
            students.Add(1, "Ahmet GÜR");
            students.Add(2, "Engin DEMİROĞ");
            students.Add(3, "Berkay BİLGİN");
            students.Add(4, "Eda KAVANOZ");
            students.Add(5, "Ayşe YURTSEVER");

            
            Console.WriteLine(students.Count);
            Console.ReadLine();
            
        }
    }
}
