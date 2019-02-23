using System.ComponentModel.DataAnnotations;

namespace ChopstickDocker.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}