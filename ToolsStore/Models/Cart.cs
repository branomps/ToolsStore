using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToolsStore.Models
{
    public class Cart
    {
        [Key]
        public virtual int RecordId { get; set; }
        public virtual String CartId { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int Count { get; set; }
        public System.DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }

    }
}