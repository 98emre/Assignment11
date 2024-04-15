using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {

        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id {  get; set; }

        [Required]
        [StringLength(255, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [Range(0,1000000)]
        public int Price { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Orderdate { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 2)]
        public string Category { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 1)]
        public string Shelf { get; set; }

        [Range(0,1000)]
        public int Count { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

    }
}
