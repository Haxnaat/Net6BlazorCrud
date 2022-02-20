using System.ComponentModel.DataAnnotations;

namespace SportingApp.Data.Domain
{
    public class Technician
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; } = string.Empty;

    }
}
