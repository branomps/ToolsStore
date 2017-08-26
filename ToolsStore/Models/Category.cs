using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ToolsStore.Models
{
    public class Category
    {
        public virtual int CategoryId { get; set; }
        [DisplayName("Category")]
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
