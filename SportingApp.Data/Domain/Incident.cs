using System.ComponentModel.DataAnnotations;

namespace SportingApp.Data.Domain
{
    public class Incident
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public DateTime DateOpened { get; set; }
        public DateTime? DateClosed { get; set; }
        [Required]
        public long CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
        [Required]
        public long ProductId { get; set; }
        public virtual Product? Product { get; set; }
        [Required]
        public long TechnicianId { get; set; }
        public virtual Technician? Technician { get; set; }
    }
}
