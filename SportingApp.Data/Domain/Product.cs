using System.ComponentModel.DataAnnotations;

namespace SportingApp.Data.Domain
{
    public  class Product
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string Code { get; set; } = string.Empty;
        [Required]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets allowed.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [RegularExpression("^[0-9]\\d{0,9}(\\.\\d{1,3})?%?$", ErrorMessage = "Only Numbers allowed.")]
        public double Price { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }

    }
}
