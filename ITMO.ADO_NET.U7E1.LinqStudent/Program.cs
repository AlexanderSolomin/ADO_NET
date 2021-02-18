using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ADO_NET.U7E1.LinqStudent
{
    class Program
    {
        static List<Student> students = new List<Student>
            {
                new Student {First="Svetlana", Last="Omelchenko", ID=111,
                    Scores = new List<int> {96, 92, 81, 60}},
                new Student {First="Claire", Last="O’Donnell", ID=112,
                    Scores = new List<int> {75, 84, 91, 39}},
                new Student {First="Sven", Last="Mortensen", ID=113,
                    Scores = new List<int> {88, 94, 65, 91}},
                new Student {First="Cesar", Last="Garcia", ID=114,
                    Scores=new List<int> {97, 89, 85, 82}},
                new Student {First="Debra", Last="Garcia", ID=115,
                    Scores=new List<int> {35, 72, 91, 70}},
            };
        static void Main(string[] args)
        {
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 90 && student.Scores[3] < 80
                select student;
            var studentQueryW = students.Where(st => st.Scores[0] > 90 && st.Scores[3] < 80);

            foreach (Student student in studentQueryW)
            {
                Console.WriteLine($"{nameof(studentQueryW)} {student.Last}, {student.First}");
            }

            int studentCount = (
                from student in students
                where student.Scores[0] > 90 && student.Scores[3] < 80
                select student).Count();

            int studentCountW = students.Where(st => st.Scores[0] > 90 && st.Scores[3] < 80).Count();

            Console.WriteLine($"{nameof(studentCountW)} {studentCount}, {studentCountW}");

            var studentList = (
                from student in students
                where student.Scores[0] > 90 //&& student.Scores[3] < 80
                orderby student.Scores[0] descending
                select student).ToList();
            foreach (Student student in studentList)
            {
                Console.WriteLine($"{nameof(studentList)} {student.Last}, {student.First} score {student.Scores[0]}");
            }

            var studentQuery2 =
                from student in students
                group student by student.Last[0];

            foreach (var studentGroup in studentQuery2)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (var student in studentGroup)
                {
                    Console.WriteLine($"  {student.Last}, {student.First}");
                }
            }
        }
    }
}
