
using ConsoleApp1.Models;
using library;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee e = new Employee();
            e.name = "Test";
            Student s = new Student();
            s.Id = 12; // lời gọi đến setter

            Console.WriteLine("Id: " + s.Id);//lời gọi đến getter(nếu không có dấu bằng ở đằng sau)

            Student s1 = new Student(1, "Minh");
            s1.Display();

            seStudent s2 = new seStudent(2, "Minh", "Java");
            s2.Display();

            seStudent s3 = new seStudent();
            s3.Input();
            s3.Display();
        }

        public static void DemoArratList()
        {
            ArrayList list = new ArrayList();
            list.Add(2);
            list.Add(4);
            list.Add("sâmskajs");// phát sinh lỗi runtime


            int sum =(int)list[0] + (int)list[1];
            Console.WriteLine(sum);

            ArrayList a2 = new ArrayList(); 
            a2.Add(new Student(1, "Hoang"));
            a2.Add(new Employee());
            a2.Add(new Student(1, "Hoang"));
            //((Student)a2[0]).Display(); phát sinh lỗi runtime

        }
        public static void DemoList()
        {
            List<int> list = new List<int>();   
            list.Add(12);
            //list.Add("áhjahsjah"); lỗi complie    
            list.Add(2);

            int sum = list[1] + list[0];

            List<Student> s = new List<Student>();
            s.Add(new Student(1, "Minh"));
            s.Add(new seStudent(1, "Minh", ".net"));
            //s.Add(new Employee()); loi complie
            s[1].Display();
            

        }
    }
}