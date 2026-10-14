namespace Westcoast_Education;

public class Teachers : Person
{


    public string? FieldOfKnowledge { get; set; }




    // public static List<Teachers> ListAll()
    // {
    //     var _path = Environment.CurrentDirectory + "/Data/presentaion.json";
    //     var json = Presentaion<Teachers>.Read(_path);
    //     return json;
    // }

    public override string ToString()
    {
        return $"Namn: {FirstName} Efternamn: {LastName} Telefonummer: {PhoneNumber} Adress: {Address} Postnummer: {Postcode} Stad: {City}";
    }

}
