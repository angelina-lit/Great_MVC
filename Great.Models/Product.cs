using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace GreatFilms.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public string Producer { get; set; }
        [Required]
        [Display(Name = "Previous price")]
        [Range(1, 1000)]
        public double PreviousPrice { get; set; }

        [Required]
        [Display(Name = "Price for 1-4")]
        [Range(1, 1000)]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Price for 4-8")]
        [Range(1, 1000)]
        public double Price4 { get; set; }

        [Required]
        [Display(Name = "Price for 9+")]
        [Range(1, 1000)]
        public double Price9 { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
		[ValidateNever]
		public string ImageUrl { get; set; }
    }
}
