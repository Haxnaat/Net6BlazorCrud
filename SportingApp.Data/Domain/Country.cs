using System.ComponentModel.DataAnnotations;

namespace SportingApp.Data.Domain
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}
