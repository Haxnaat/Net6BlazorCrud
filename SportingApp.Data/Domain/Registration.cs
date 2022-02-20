using System.ComponentModel.DataAnnotations;

namespace SportingApp.Data.Domain
{
    public class Registration
    {
        [Key]
        public long Id { get; set; }    
        [Required]
        public long CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
        [Required]
        public long ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
