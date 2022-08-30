using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
namespace FirstResponsiveWebAppChristensen.Models
{
    public class UserAgeModel
    {
        private int Year = DateTime.Now.Year;
        [Required(ErrorMessage = "Please enter your birth year")]
        [Range(1920, 2021, ErrorMessage = "Please enter a year between 1920 and 2021")]
        public int birthYear { get; set; }
        [Required(ErrorMessage = "Please enter your Name")]
        public string Name { get; set; }

        public int AgeThisYear()
        {
            int Age = 0;
            Age = Year - birthYear;
            return Age;
        }

    }
}
