using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ToolsStore.Models
{
    public class Brand
    {
        public virtual int BrandId { get; set; }
        [DisplayName("Brand")]
        public virtual string Name { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}