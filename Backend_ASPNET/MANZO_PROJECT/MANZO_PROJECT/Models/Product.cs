using System.ComponentModel.DataAnnotations;

namespace MANZO_PROJECT.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace MANZO_PROJECT.Models
    {
        public class Product
        {
            [Key]
            public int ProductId { get; set; }

            [Required]
            public int UserId { get; set; }

            [Required]
            [MaxLength]
            public string Category { get; set; }

            [Required]
            [MaxLength]
            public string Cover { get; set; }

            [Required]
            public DateTime CreatedAt { get; set; }

            [Required]
            public int DeliveryTime { get; set; }

            [Required]
            [MaxLength]
            public string Desc { get; set; }

            [Required]
            [MaxLength]
            public string Features { get; set; }

            [Required]
            [MaxLength]
            public string Images { get; set; }

            [Required]
            public decimal Price { get; set; }

            public int? ProductId1 { get; set; }

            [Required]
            public int RevisionNumber { get; set; }

            [Required]
            public int Sales { get; set; }

            [Required]
            [MaxLength]
            public string ShortDesc { get; set; }

            [Required]
            [MaxLength]
            public string ShortTitle { get; set; }

            [Required]
            [MaxLength(255)]
            public string Title { get; set; }

            [Required]
            public DateTime UpdatedAt { get; set; }

            // Additional properties
            public double Weight { get; set; }

            public int StockQuantity { get; set; }

            public bool IsFeatured { get; set; }

            public bool IsAvailable { get; set; }

            [MaxLength]
            public string Manufacturer { get; set; }

            [MaxLength]
            public string Model { get; set; }

            public double Rating { get; set; }

            public int ReviewsCount { get; set; }

            public bool IsNew { get; set; }

            public bool IsTopSeller { get; set; }
        }
    }

}
