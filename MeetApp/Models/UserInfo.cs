using System.ComponentModel.DataAnnotations;

namespace MeetApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Ad alani Zorunlu")]
        public string? Name { get; set; } 
        [Required(ErrorMessage = "Telefon alani Zorunlu")]
        public string? Phone{ get; set; }
        [Required(ErrorMessage = "Ad alani Zorunlu")]
        [EmailAddress(ErrorMessage="Hatali Email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Katilim durumunuzu belirtiniz.")]
        public bool? WillAttend { get; set; }




    }
}
