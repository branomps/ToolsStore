using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToolsStore.Models
{
    public class Brand
    {
        public virtual int BrandId { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}