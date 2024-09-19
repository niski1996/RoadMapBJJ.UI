using RoadMapBJJ.Contracts.Entities.Persons;

namespace RoadMapBJJ.UI.DTOs;

public class UserRegistrationModel
{
    public User? User { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? Club { get; set; }
    public string? Citizenship { get; set; }
    public DateTime Birthday { get; set; }
    public string? Phone { get; set; }
    public string? Mobile { get; set; }
    public string? EmailConfirmed { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public string? ZipCode { get; set; }
    public string? Country { get; set; }
    public string? Building { get; set; }
    public string? Local { get; set; }
}