//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAYQuiltProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrderHistories = new HashSet<OrderHistory>();
        }
    
        public int OrderId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }
    
        public virtual Quilt Quilt { get; set; }
        public virtual Recipient Recipient { get; set; }
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
