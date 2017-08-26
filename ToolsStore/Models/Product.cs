using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToolsStore.Models
{
    public class Product
    {
        public virtual int ProductId { get; set; }
        [Required]
        public virtual int BrandId { get; set; }
        [Required]
        public virtual int CategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public virtual string Title { get; set; }
        [DisplayName("Price")]
        [Required]
        public virtual decimal Price { get; set; }
        [Required]
        public virtual string ProductImgUrl { get; set; }
        [Required]
        public virtual string Description { get; set; }
        [DisplayName("Brand")]
        public virtual Brand Brand { get; set; }
        [DisplayName("Category")]
        public virtual Category Category { get; set; }



    }
}