using Excercise;
namespace Excercise
{
    class Program
    {
        private static void Main(string[] args)
        {
            CourseList list = new CourseList();
            list.InputListOfCourse();
            list.DisplayListOfCourse();
            list.SearchByStartDate();
        }
    }

}