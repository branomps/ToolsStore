using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToolsStore.Models
{
    public class Order
    {
        [Key]
        public virtual int OrderId { get; set; }
        public virtual string UserName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string Country { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Email { get; set; }
        public virtual decimal Total { get; set; }

        public virtual System.DateTime OrderDate { get; set; }

        public IList<OrderDetail> OrderDetails { get; set; }


     

    }
}