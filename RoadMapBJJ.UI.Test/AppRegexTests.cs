using System.Text.RegularExpressions;
using RoadMapBJJ.UI.Common;

namespace RoadMapBJJ.UI.Test;


public class AppRegexTests
{
    [Theory]
    [InlineData(AppRegex.PasswordRegex, "Password1!", true)] // Poprawne hasło
    [InlineData(AppRegex.PasswordRegex, "Password", false)] // Brak cyfry
    [InlineData(AppRegex.PasswordRegex, "password1!", false)] // Brak wielkiej litery
    [InlineData(AppRegex.PasswordRegex, "PASSWORD1!", false)] // Brak małej litery
    [InlineData(AppRegex.PasswordRegex, "Pass1", false)] // Za krótkie
    //
    [InlineData(AppRegex.BaseRegex, "John", true)]         // Poprawne imię
    [InlineData(AppRegex.BaseRegex, "John_Doe", true)]     // Znak podkreślenia
    [InlineData(AppRegex.BaseRegex, "John-Doe", true)]     // Myślnik
    [InlineData(AppRegex.BaseRegex, "John.Doe", true)]     // Kropka
    [InlineData(AppRegex.BaseRegex, "J", false)]           // Zbyt krótkie
    [InlineData(AppRegex.BaseRegex, "John123", false)]     // Zawiera cyfry
    
    [InlineData(AppRegex.LastNameRegex, "Nowak", true)]                // Poprawne nazwisko
    [InlineData(AppRegex.LastNameRegex, "Nowak-Kowalski", true)]       // Nazwisko z myślnikiem
    [InlineData(AppRegex.LastNameRegex, "nowak", false)]               // Brak wielkiej litery na początku
    [InlineData(AppRegex.LastNameRegex, "Nowak-Kowalski-Nowak", false)]// Za dużo myślników
    
    [InlineData(AppRegex.PostalCodeRegex, "00-123", true)]   // Poprawny kod pocztowy
    [InlineData(AppRegex.PostalCodeRegex, "00123", false)]   // Brak myślnika
    [InlineData(AppRegex.PostalCodeRegex, "00-1234", false)] // Za dużo cyfr
    [InlineData(AppRegex.PostalCodeRegex, "00-12a", false)]  // Zawiera literę

    [InlineData(AppRegex.LastNameRegex, "Nowak1", false)]    
    public void TestPasswordRegex(string regexPattern, string password, bool expected)
    {
        var regex = new Regex(regexPattern);
        Assert.Equal(expected, regex.IsMatch(password));
    }
}
