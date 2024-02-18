namespace SeminarHub.Data
{
    public class DataConstants
    {
        public const int SeminarTopicMaxlength = 100;
        public const int SeminarTopicMinlength = 3;
               
        public const int SeminarLecturerMaxlength = 60;
        public const int SeminarLecturerMinlength = 5;
               
        public const int SeminarDetailsMaxlength = 500;
        public const int SeminarDetailsMinlength = 10;

        public const int SeminarDurationMaxlength = 180;
        public const int SeminarDurationMinlength = 30;

        public const string DateFormat = "dd/MM/yyyy HH:mm";


        public const int CategoryNameMaxlength = 50;
        public const int CategoryNameMinlength = 3;

        public const string RequireErrorMessage = "The field {0} is required";
        public const string StringLengthErrorMessage = "The field {0} must be between {2} and {1} characters long";
        public const string RangeIntErrorMessage = "The field {0} must be between {1} and {2} characters long";


    }
}
