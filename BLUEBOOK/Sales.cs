//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLUEBOOK
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sales
    {
        public Sales()
        {
            this.InvoicesDetails = new HashSet<InvoicesDetails>();
            this.OrdersDetails = new HashSet<OrdersDetails>();
        }
    
        public int Book_ID { get; set; }
        public int Sales_Price { get; set; }
        public int Purchasing_Price { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual ICollection<InvoicesDetails> InvoicesDetails { get; set; }
        public virtual ICollection<OrdersDetails> OrdersDetails { get; set; }
    }
}