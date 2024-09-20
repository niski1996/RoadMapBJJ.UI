using Microsoft.AspNetCore.Mvc.ModelBinding;
using RoadMapBJJ.Contracts.Entities.Persons;
using RoadMapBJJ.Contracts.Enums;

namespace RoadMapBJJ.UI.DTOs
{
    public class UserRegistrationModel : IEditTrackable
    {
        private string? _name;
        private string? _lastName;
        private string? _email;
        private string? _password;
        private string? _club;

        public UserRegistrationModel()
        {
            User = new UserModel();
        }

        public UserModel User { get; set; }

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

        public string? Club
        {
            get => _club;
            set
            {
                if (value != _club)
                {
                    _edited = true;
                    _club = value;
                }
            }
        }

        private bool _edited;
        public bool WasEdited => _edited;
    }

    public class ContactModel : IEditTrackable
    {
        private string? _email;
        private Nationality? _citizenship;
        private string? _phone;
        private bool _emailConfirmed;
        private bool _edited;

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

        public Nationality? Citizenship
        {
            get => _citizenship;
            set
            {
                if (value != _citizenship)
                {
                    _edited = true;
                    _citizenship = value;
                }
            }
        }

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

        public string? City { get; set; }
        public string? Street { get; set; }
        public string? ZipCode { get; set; }
        public Country Country { get; set; }
        public string? Building { get; set; }
        public string? Local { get; set; }

        public bool WasEdited => _edited;
    }

    public class UserModel : IEditTrackable
    {
        private string? _citizenship;
        private string? _userName;
        private string? _name;
        private string? _lastName;
        private string? _password;
        private string? _email;
        private string? _phoneNumber;
        private DateOnly? _birthDate;
        private bool _edited;

        public string? Citizenship
        {
            get => _citizenship;
            set
            {
                if (value != _citizenship)
                {
                    _edited = true;
                    _citizenship = value;
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

        public string? PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value != _phoneNumber)
                {
                    _edited = true;
                    _phoneNumber = value;
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
}

public interface IEditTrackable
{
    public bool WasEdited { get; }
}

public class ContactModel :IEditTrackable
{
    private string? _email;
    public string? Email
    {
        get => _email;
        set
        {
            if (value!=Email)
            {
                _edited=true; 
                _email=value;
                
            }   
        }
    }

    public Nationality? Citizenship
    {
        get => _citizenship;
        set => _citizenship = value;
    }

    public string? Phone
    {
        get => _phone;
        set => _phone = value;
    }

    public bool EmailConfirmed
    {
        get => _emailConfirmed;
        set => _emailConfirmed = value;
    }

    public string? City { get; set; }
    public string? Street { get; set; }
    public string? ZipCode { get; set; }
    public Country Country { get; set; }
    public string? Building { get; set; }
    public string? Local { get; set; }
    
    private bool _edited;
    private Nationality? _citizenship;
    private string? _phone;
    private bool _emailConfirmed;

    public bool WasEdited { get;}
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