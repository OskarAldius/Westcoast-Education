namespace Westcoast_Education;

public class Teachers : Person
{


    public string? FieldOfKnowledge { get; set; }


    public override string ToString()
    {
        return $"Namn: {FirstName} Efternamn: {LastName} Telefonummer: {PhoneNumber} Adress: {Address} Postnummer: {Postcode} Stad: {City}";
    }

}
