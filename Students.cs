using System.Security.Cryptography;

namespace Westcoast_Education;

public class Students : Person
{



    public override string ToString()
    {
        return $"Student namn: {FirstName} Student efternamn: {LastName} Telefonummer: {PhoneNumber} Adress: {Address} Postnummer: {Postcode} Stad: {City}";
    }
}
