namespace Homies.Data
{
    public class DataConstants
    {
        //Class Event.cs   

        public const int EventNameMaxLenght = 20;
        public const int EventNameMinLenght = 5;

        public const int EventDescriptionMaxLenght = 150;
        public const int EventDescriptionMinLenght = 15;

        public const string DateFormat = "yyyy-MM-dd H:mm";

        //Class Type.cs

        public const int TypeNameMaxLenght = 15;
        public const int TypeNameMinLenght = 5;

        //Error Massages

        public const string RequireErrorMasage = "The field {0} is required";

        public const string StringLenghtErrorMassage = "The field {0} must be between {2} and {1} character long";

    }
}
