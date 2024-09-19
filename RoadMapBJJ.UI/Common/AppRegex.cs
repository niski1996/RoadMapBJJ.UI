namespace RoadMapBJJ.UI.Common
{
    public static class AppRegex
    {
        public const string PasswordRegex = "^(?!.([A-Za-z0-9])\\1{1})(?=.?[A-Z])(?=.?[a-z])(?=.?[0-9])(?=.?[#?!@$%^&-]).{8,}$";
        public const string PasswordInfo = "Password must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, one number, and one special character.";
        
        public const string BaseRegex = "^[A-Za-z_\\.-]+$";
        public const string BaseInfo = "Must contain only letters, underscores, dots, or hyphens, and be at least 2 characters long.";
        
        public const string LastNameRegex = "^[A-Z][a-z]+(-[A-Z][a-z]+)?$";
        public const string LastNameInfo = "Last name must start with a capital letter and contain only letters. Hyphenated last names are allowed.";

        public const string PostalCodeRegex = "^[0-9]{2}-[0-9]{3}$";
        public const string PostalCodeInfo = "Postal code must be in the format 00-000.";

    }
}