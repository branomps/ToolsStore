using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToolsStore.Models
{
    public class Product
    {
        public virtual int ProductId { get; set; }
        public virtual int BrandId { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string ProductImgUrl { get; set; }
        public virtual string Description { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }



    }
}