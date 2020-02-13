using System.ComponentModel.DataAnnotations;

namespace HCL.HackatonHotels.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}