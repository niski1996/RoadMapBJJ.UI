using RoadMapBJJ.Contracts.Entities.Persons;
using RoadMapBJJ.Contracts.Enums;

namespace RoadMapBJJ.UI.DTOs;

public class UserRegistrationModel
{
    public UserRegistrationModel()
    {
        User = new UserModel();
    }

    public UserModel User { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? Club { get; set; }


}

public class ContactModel
{    
    public string? Email { get; set; }
    public Citizenship? Citizenship { get; set; }
    public string? Phone { get; set; }
    public bool EmailConfirmed { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public string? ZipCode { get; set; }
    public Country Country { get; set; }
    public string? Building { get; set; }
    public string? Local { get; set; }
    
}




public class UserModel
{
    public string? Citizenship { get; set; }
    public string? UserName { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public DateOnly? BirthDate { get; set; }
}