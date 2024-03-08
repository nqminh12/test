using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    internal class CourseList
    {
        List<Course> courses;
        public CourseList() {
            courses = new List<Course>();
        }

        public void InputListOfCourse()
        {
            while (true)
            {
                Console.WriteLine("Course(C)? OnlineCourse(O)? Stop(S)?");
                string type = Console.ReadLine();
                if (type.ToUpper().Equals("S")) break;
                Course c;
                if(type.ToUpper().Equals("C")) c = new Course();
                else c = new OnlineCourse();
                c.Input();
                courses.Add(c);

            }
        }

        public void DisplayListOfCourse() {
            Console.WriteLine("List of Course: ");
            foreach (Course c in courses)
            {
                Console.WriteLine(c);
            }
        }

        public void Search(DateTime startDate, DateTime endDate)
        {
            Console.WriteLine("Danh sach cac Course tim dc: ");
            foreach (Course c in courses)
            {
                if(c.StartDate >= startDate && c.StartDate <= endDate)
                {
                    Console.WriteLine(c);
                }
            }
        }

        public void SearchByStartDate()
        {
            DateTime startDate = Validation.GetDateTime(new DateTime(2020, 1, 1),
                                                new DateTime(2022, 12, 31),
                                                "dd-MM-yyyy", "Nhap ngay bat dau: ");
            DateTime endDate = Validation.GetDateTime(new DateTime(2020, 1, 1),
                                                new DateTime(2022, 12, 31),
                                                "dd-MM-yyyy", "Nhap ngay ket thuc: ");
            Search(startDate, endDate);
        }

        public void ReadListOfCourseFromFile(string filename)
        {

        }

        public void InitDate()
        {
            courses.Add(new Course(1, "PRJ", new DateTime(2022, 1, 1)));
            courses.Add(new Course(1, "CSD", new DateTime(2022, 1, 1)));
            courses.Add(new Course(1, "OSG", new DateTime(2022, 1, 1)));
            courses.Add(new Course(1, "PRN", new DateTime(2022, 1, 1)));
        }

        public void Sort()
        {
            courses.Sort();
        }

        public int IdComparison(Course c1, Course c2)
        {
                return c1.Id.CompareTo(c2.Id);
        }

        public void SortById()
        {
            //courses.Sort(new IdComparers());
            //courses.Sort(IdComparison);
            courses.Sort(
                (c1, c2) => c1.Id.CompareTo(c2.Id)
                ) ;
        }   

        public void SortByStartDate()
        {
            courses.Sort(new StartDateComparers());
        }
    }
}
