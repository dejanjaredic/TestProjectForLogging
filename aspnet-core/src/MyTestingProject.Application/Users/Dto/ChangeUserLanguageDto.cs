using System.ComponentModel.DataAnnotations;

namespace MyTestingProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}