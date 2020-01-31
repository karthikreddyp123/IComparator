using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparator
{
    class Program
    {
        static void Main(string[] args)
        {

            Student[] arrStudent = new Student[] 
            { 
                new Student() { Name = "Karthik" , Marks=90},
                new Student() { Name = "Rahul" , Marks=60},
                new Student() { Name = "Vivek" , Marks=70},
                new Student() { Name = "Aditya" , Marks=100}
            };
            Console.WriteLine("Sorting done through Comparable");
            Array.Sort(arrStudent);
            foreach (Student i in arrStudent)
            {
                Console.WriteLine(i.Name);
            }
            MarksComparer studentComparer = new MarksComparer();
            Array.Sort(arrStudent, studentComparer);
            Console.WriteLine("Sorting done through Comparable");
            foreach (Student i in arrStudent)
            {
                Console.WriteLine(i.Name);
            }
            Console.ReadLine();
        }
    }
    public class Student : IComparable
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public int CompareTo(object obj)
        {
            Student stuObj = obj as Student;
            if (stuObj != null)
            {
                return this.Name.CompareTo(stuObj.Name);
            }
            return -1;
        }
    }
    public class MarksComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Marks.CompareTo(y.Marks);
        }
    }
}
