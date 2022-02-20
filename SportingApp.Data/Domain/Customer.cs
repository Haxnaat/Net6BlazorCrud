using System.ComponentModel.DataAnnotations;

namespace SportingApp.Data.Domain
{
    public class Customer
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "First Name is too long.")]
        public string FirstName { get; set; }=string.Empty;
        [Required]
        [StringLength(20, ErrorMessage = "Last Name is too long.")]
        public string LastName { get; set; }=string.Empty;
        [Required]
        public string Address { get; set; }=string.Empty;
        [Required]
        public string City { get; set; }=string.Empty;
        [Required]
        public string State { get; set; }=string.Empty;
        [Required]
        public string PostalCode { get; set; }=string.Empty;
        
        public string Email { get; set; }=string.Empty;
        
        public string Phone { get; set; } = String.Empty;
        [Required]
        public int CountryId { get; set; }
        public virtual Country? Country { get; set; }
    }
}
