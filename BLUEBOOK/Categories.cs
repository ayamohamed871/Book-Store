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
    
    public partial class Categories
    {
        public Categories()
        {
            this.Books = new HashSet<Books>();
            this.Stocks = new HashSet<Stocks>();
        }
    
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Books> Books { get; set; }
        public virtual ICollection<Stocks> Stocks { get; set; }
    }
}
