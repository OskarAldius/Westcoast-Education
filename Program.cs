using System.Security.Cryptography.X509Certificates;

namespace Westcoast_Education;

class Program
{
    static void Main()
    {


        Students students1 = new()
        {
            FirstName = "Jonas",
            LastName = "Axelsson",
            PhoneNumber = "+46-707-632789",
            Address = "Stenbyn 29",
            Postcode = "39293",
            City = "Hjo",


        };
        Students students2 = new()
        {
            FirstName = "Bertil",
            LastName = "Axelsson",
            PhoneNumber = "+46-707-897298",
            Address = "Stenbyn 29",
            Postcode = "39293",
            City = "Hjo",


        };
        List<Students> student = new();
        student.Add(students1);
        student.Add(students2);

        Teachers teachers = new()
        {

            FirstName = "Anders",
            LastName = "Nilsson",
            FieldOfKnowledge = "Mattematik",
            PhoneNumber = "+46-707-4628023",
            Address = "Hammargatan 5",
            Postcode = "33292",
            City = "Jönköping",



        };
        Teachers teacher1 = new()
        {

            FirstName = "Karl",
            LastName = "Karlsson",
            FieldOfKnowledge = "Svenska",
            PhoneNumber = "+46-707-4628023",
            Address = "brunsbogatan 5",
            Postcode = "45672",
            City = "Göteborg",



        };

        Course course = new()
        {
            Teacher = teachers,
            Students = student,
            CourseNumber = "1",
            Title = "Mattematik 2b",
            CourseLength = "15 veckor",
            StartDate = new DateTime(2027, 9, 1),
            EndDate = new DateTime(2027, 12, 21),
            CourseType = CourseType.Distance




        };


        Course course1 = new()
        {
            Teacher = teacher1,
            Students = student,
            CourseNumber = "2",
            Title = "Svenska",
            CourseLength = "15 veckor",
            StartDate = new DateTime(2027, 9, 1),
            EndDate = new DateTime(2027, 12, 21),
            CourseType = CourseType.Distance

        };
        course.Add();
        course1.Add();




        List<Course> courses = Course.ListAll();

        foreach (var savedCourse in courses)
        {
            System.Console.WriteLine(savedCourse);
        }

    }
}
