using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        [Required(ErrorMessage ="Ad alanı zorunlu")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Telefon numarası giriniz")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="Ad alanı zorunlu")]
        [EmailAddress(ErrorMessage ="Hatalı email")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Katılım durumunuzu belirtiniz")]
        public bool? WillAttend { get; set; }
        [Required]
        public int Id { get; set; }
    }
}