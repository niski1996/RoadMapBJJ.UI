namespace RoadMapBJJ.UI.DTOs;

public class UserRegistrationModel : IEditTrackable
{

    public UserRegistrationModel()
    {
        Contact = new ContactModel();
        User = new UserModel();
    }

    public UserModel User { get; }
    public ContactModel Contact { get; }

        
    public bool WasEdited => User.WasEdited || Contact.WasEdited;
}