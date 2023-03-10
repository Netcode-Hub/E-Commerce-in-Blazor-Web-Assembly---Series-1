using System.ComponentModel.DataAnnotations;

namespace ORMExplained.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, StringLength(50, MinimumLength = 6)]
        public string? Name { get; set; }
        [Required, DataType(DataType.Currency)]
        public double OriginalPrice { get; set; } = 0.52;
        [DataType(DataType.Currency)]
        public double NewPrice { get; set; } = 0.00;
        [Required, StringLength(1000, MinimumLength = 10)]
        public string? Description { get; set; }
        [Required]
        public int Quantity { get; set; } = 1;
        [Required]
        public string? Image { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime UploadedDate { get; set; } = DateTime.Now;
    }
}
