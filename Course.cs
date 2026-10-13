namespace Westcoast_Education;

public class Course
{
    public List<Course> _courses = [];
    public string? CourseNumber { get; set; }
    public string? Title { get; set; }
    public string? CourseLength { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public CourseType CourseType { get; set; }
    public Teachers? Teacher { get; set; }
    public List<Students> Students { get; set; } = [];

    private static readonly string _path = string.Concat(Environment.CurrentDirectory, "/Data/presentaion.json");


    public override string ToString()
    {
        string studentInfo = "";

        if (Students != null)
        {
            foreach (Students students in Students)
            {
                studentInfo += $"{students.FirstName} {students.LastName}\n";
            }
        }

        return $"Titel: {Title}\n" +
        $"Kurs nummer: {CourseNumber}\n" +
        $"Kurslängd: {CourseLength}\n" +
        $"Kurs start: {StartDate}\n" +
        $"Kurs slut: {EndDate}\n" +
        $"Lärare {Teacher}\n" +
        $"Studenter\n" +
        $"{studentInfo}";

    }



    public static List<Course> ListAll()
    {
        return Presentaion<Course>.Read(_path);
    }
    public void Add()
    {

        List<Course> courses = Presentaion<Course>.Read(_path);
        courses.Add(this);
        Presentaion<Course>.Write(_path, courses);

    }


}
