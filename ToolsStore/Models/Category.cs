﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToolsStore.Models
{
    public class Category
    {
        public virtual int CategoryId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}