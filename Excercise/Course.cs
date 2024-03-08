using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    class Course: IComparable<Course>
    {
        public Course()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public Course(int id, string title, DateTime startDate)
        {
            Id = id;
            Title = title;
            StartDate = startDate;
        }

        public override string ToString()
        {
            return $"{Id} - {Title} - {StartDate.ToString("dd-MM-yyyy")}";
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap thong tin Course: ");
            Id = Validation.GetInteger(0, 20000, "Nhap Id: ");
            Title = Validation.GetString(1, 100, "Nhap Title: ");
            StartDate = Validation.GetDateTime(new DateTime(2020,1,1), 
                                                new DateTime(2022,12,31), 
                                                "dd-MM-yyyy", "Nhap ngay bat dau: ");
        }

        public int CompareTo(Course other)
        {
            return this.Title.CompareTo(other.Title);
        }
    }

    class OnlineCourse : Course
    {
        public OnlineCourse()
        {
        }

        public string Meet { get; set; }

        public OnlineCourse(int id, string title, DateTime startdate, string meet) : base(id, title, startdate)
        {
            Meet = meet;
        }

        public override string ToString() { 
            return base.ToString() + $"{Meet}";
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Link Meet: ");
            Meet = Console.ReadLine();
        }
    }
}
