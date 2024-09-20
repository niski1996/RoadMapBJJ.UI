namespace RoadMapBJJ.UI.DTOs;

public class UserModel : IEditTrackable
{
    private string? _nationality;
    private string? _userName;
    private string? _name;
    private string? _lastName;
    private string? _password;
    private DateOnly? _birthDate;
    private bool _edited;

    public string? Nationality
    {
        get => _nationality;
        set
        {
            if (value != _nationality)
            {
                _edited = true;
                _nationality = value;
            }
        }
    }

    public string? UserName
    {
        get => _userName;
        set
        {
            if (value != _userName)
            {
                _edited = true;
                _userName = value;
            }
        }
    }

    public string? Name
    {
        get => _name;
        set
        {
            if (value != _name)
            {
                _edited = true;
                _name = value;
            }
        }
    }

    public string? LastName
    {
        get => _lastName;
        set
        {
            if (value != _lastName)
            {
                _edited = true;
                _lastName = value;
            }
        }
    }

    public string? Password
    {
        get => _password;
        set
        {
            if (value != _password)
            {
                _edited = true;
                _password = value;
            }
        }
    }
    
    public DateOnly? BirthDate
    {
        get => _birthDate;
        set
        {
            if (value != _birthDate)
            {
                _edited = true;
                _birthDate = value;
            }
        }
    }

    public bool WasEdited => _edited;

}