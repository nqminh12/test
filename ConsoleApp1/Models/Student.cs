using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Student
    {
        //private feild
        int id;
        

        //property
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if(value > 0)
                {
                    id = value;
                }
                else { id = 0;}
            }
        }
        //viết tắt
        public string Name
        {
            get; set;
        }

        public Student()
        {
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public virtual void Display()
        {
            //Console.WriteLine("Student Id: " + Id + " , Name :" + Name);
            Console.WriteLine($"Student: Id:{Id}, Name: {Name}");
            //Console.WriteLine(String.Format("Student: Id:{0}, Name:{1}", Id, Name));
        }
        public void Input()
        {
            Console.WriteLine("Nhap Id: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap name: ");
            Name = Console.ReadLine();
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   Id == student.Id &&
                   Name == student.Name;
        }
    }

    // kế thừa lớp cha trc, sau đó mới là accs interrface
    class seStudent : Student {
        public string Skill {  get; set; }
        // nếu ko gọi hàm tạo cho con nó sẽ mặc định gọi hàm tạo không tham số của lớp cha
        public seStudent()
        {
        }

        public seStudent(int id, string Name, string skill): base(id, Name)//lời gọi hàm tạo lớp cha
        {
            Skill = skill;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($",Skill: {Skill}");
        }
        public void Input()
        {
            base.Input();
            Console.WriteLine("Nhap skill: ");
            Skill = Console.ReadLine();
        }

    }
}
