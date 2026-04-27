using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAfairs
{
    public class CitizenProfile
    {
        //
        public string FullName { get; set; }
        public string IDNumber { get; set; }

        // Age is calculated from ID and is read-only. Hence a private setter. Only the CitizenProfile class itself can modify it
        public int Age { get; private set; }
        public string CitizenshipStatus { get; set; }

        // Constructor to initialize the citizen profile
        public CitizenProfile(string name, string id, string citizenship)
        {
            FullName = name;
            IDNumber = id;
            CitizenshipStatus = citizenship;
            Age = CalculateAge();
        }

        // Method to calculate age from the ID number. If fails to calculate age, it will return -1
        private int CalculateAge()
        {
            try
            {
                //yymmddxxxxxxx
                string yy = IDNumber.Substring(0, 2); // Extract the year part (first 2 digits)
                string mm = IDNumber.Substring(2, 2); // Extract the month part (next 2 digits)
                string dd = IDNumber.Substring(4, 2); // Extract the day part

                //convert string extracts to integers
                int year = int.Parse(yy);
                int month = int.Parse(mm);
                int day = int.Parse(dd);

                int currentYear = DateTime.Now.Year % 100; // Determine the full year using the modulus operator to get the last two digits of the current year
                //returns 26

                //determine the full year before calculating the age for accurate calculations.
                int fullYear = (year <= currentYear) ? 2000 + year : 1900 + year; // If the year is less than or equal to the current year's last two digits, it's in the 2000s; otherwise, it's in the 1900s. then calculates the full year

                //Creating a DateTime object for the birth date for further calculations
                DateTime birthDate = new DateTime(fullYear, month, day);

                int age = DateTime.Now.Year - fullYear;

                DateTime birthdayThisYear = birthDate.AddYears(age);

                //if the current date is before the birthday this year, it means the person hasn't had their birthday yet,
                //so we subtract one from the age to get the correct age.
                if (DateTime.Now < birthdayThisYear)
                    age--;

                return age;
            }
            catch
            {
                return -1; // Invalid date
            }
        }

        public string ValidateID()
        {

            if (IDNumber.Length != 13)
                return "ID must be exactly 13 digits.";

            //Validate that the id is a long value
            if (!long.TryParse(IDNumber, out _))
                return "ID must contain only numeric values.";

            //finally, check the return value. -1 means an error occurred
            if (Age < 0)
                return "Error calculating age, please try again";

            return $"Valid ID: Citizen is {Age} years old."; //if no error occurs 
        }
    }
}
