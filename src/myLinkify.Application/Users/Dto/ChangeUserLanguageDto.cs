using System.ComponentModel.DataAnnotations;

namespace myLinkify.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}