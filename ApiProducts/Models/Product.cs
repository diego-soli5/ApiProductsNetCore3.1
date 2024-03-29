﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProducts.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        public string ImageRoute { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal Stock { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public int SubCategoryId { get; set; }

        [Required]
        public int ProductStatusId { get; set; }

        [ForeignKey(nameof(ProductStatusId))]
        public ProductStatus ProductStatus { get; set; }

        [ForeignKey(nameof(SubCategoryId))]
        public SubCategory SubCategory { get; set; }
    }
}
