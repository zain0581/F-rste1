global using Første1.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første1.code
{
    internal class person
    {
      
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int telephonenr { get; set; }

        public string BirthDateInDanishFormat{ get; set; }
        public int Age { get; set; }
        public double TimeSpanInTotalDays { get; set; }

        public person(string firstname, string lastname,  DateTime Birthdaydate)

        {
            BirthDateInDanishFormat = Birthdaydate.ToString ("dd-mm-yyyy");
            Age = DateTime.Now.Year- Birthdaydate.Year;
            FirstName = firstname;
            LastName = LastName;
        }


        public person()
        {
            BirthDateInDanishFormat = "16";
            FirstName = "Thomas";
            LastName = "Jensen";
        }

        public string? GetFullName()
        {

            return $"{FirstName}{LastName}";
        }


    }
}
