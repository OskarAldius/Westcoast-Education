namespace Westcoast_Education;

public class Person : IPerson
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? Postcode { get; set; }
    public string? City { get; set; }


    public override string ToString()
    {
        return $"Namn: {FirstName} Efternamn: {LastName} Telefonummer: {PhoneNumber} Adress: {Address} Postnummer: {Postcode} Stad: {City}";
    }
}
