using System.Security.Cryptography;

namespace Westcoast_Education;

public class Students : Person
{



    public override string ToString()
    {
        return $"Namn: {FirstName} Efternamn: {LastName} Telefonummer: {PhoneNumber} Adress: {Address} Postnummer: {Postcode} Stad: {City}";
    }
}
