using RoadMapBJJ.Contracts.Enums;

namespace RoadMapBJJ.UI.DTOs;

public class ContactModel : IEditTrackable
{
    private string? _email;
    public string? Email
    {
        get => _email;
        set
        {
            if (value != _email)
            {
                _edited = true;
                _email = value;
            }
        }
    }

    private string? _phone;
    public string? Phone
    {
        get => _phone;
        set
        {
            if (value != _phone)
            {
                _edited = true;
                _phone = value;
            }
        }
    }

    private bool _emailConfirmed;
    public bool EmailConfirmed
    {
        get => _emailConfirmed;
        set
        {
            if (value != _emailConfirmed)
            {
                _edited = true;
                _emailConfirmed = value;
            }
        }
    }

    private string? _country;
    public string? Country
    {
        get => _country;
        set
        {
            if (value != _country)
            {
                _edited = true;
                _country = value;
            }
        }
    }

    private string? _city;
    public string? City
    {
        get => _city;
        set
        {
            if (value != _city)
            {
                _edited = true;
                _city = value;
            }
        }
    }

    private string? _street;
    public string? Street
    {
        get => _street;
        set
        {
            if (value != _street)
            {
                _edited = true;
                _street = value;
            }
        }
    }

    private string? _zipCode;
    public string? ZipCode
    {
        get => _zipCode;
        set
        {
            if (value != _zipCode)
            {
                _edited = true;
                _zipCode = value;
            }
        }
    }

    private string? _building;
    public string? Building
    {
        get => _building;
        set
        {
            if (value != _building)
            {
                _edited = true;
                _building = value;
            }
        }
    }

    private string? _local;
    public string? Local
    {
        get => _local;
        set
        {
            if (value != _local)
            {
                _edited = true;
                _local = value;
            }
        }
    }

    private bool _edited;
    public bool WasEdited => _edited;
}