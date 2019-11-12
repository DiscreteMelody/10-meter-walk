using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Meter_Walk
{
    public static class ValidationManager
    {
        private static string nameFormat = @"^([a-zA-Z]|\-){1,25}$";    //names are A-Z with hyphens and between 1-25 characters
        private static string nameFormatErrorMessage = "Names can only contain hyphens, letters A-Z, and cannot be longer than 25 characters.";
        private static string dateFormat = @"^[0-1]{1}[0-9]{1}\/[0-9]{2}\/[0-9]{4}$";  //dates are mm/dd/yyyy format
        private static string dateFormatErrorMessage = "Dates should be formatted mm/dd/yyyy. January 15th, 2007 would be 01/15/2007";
        private static string timeFormat = @"^[0-9]{2}:{1}[0-9]{2}$";   //times are in hh:mm am/pm format
        private static string timeFormatErrorMessage = "Times should be formatted mm:ss. a 1 minute and 40 second test would be 01:40";
        private static string noteFormat = @"^([a-zA-Z]| ){1,1000}$";    //notes are A-Z and up to 1000 characters
        private static string noteFormatErrorMessage = "Notes must be between 1-1000 characters and not contain any special characters.";

        public enum ValidationTypes { Name, Date, Time, Notes };

        /// <summary>
        /// returns true if the input is accepted by the class's regex expression, shows a message box if method returns false
        /// </summary>
        /// <param name="input">the string input</param>
        /// <param name="validation_type">the type of regex expression to be used</param>
        /// <returns></returns>
        public static bool inputIsValid(string input, ValidationTypes validation_type)
        {
            string regex = "";
            string errorMessage = "";

            if (validation_type == ValidationTypes.Name)
            {
                regex = nameFormat;
                errorMessage = nameFormatErrorMessage;
            }
                
            else if (validation_type == ValidationTypes.Date)
            {
                regex = dateFormat;
                errorMessage = dateFormatErrorMessage;
            }
                
            else if (validation_type == ValidationTypes.Time)
            {
                regex = timeFormat;
                errorMessage = timeFormatErrorMessage;
            }
                
            else if(validation_type == ValidationTypes.Notes)
            {
                regex = noteFormat;
                errorMessage = noteFormatErrorMessage;
            }

            if(Regex.IsMatch(input, regex) == false) {
                MessageBox.Show(errorMessage);
                return false;
            }

            return true;
        }
    }
}
