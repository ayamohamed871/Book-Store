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
    
    public partial class Authors
    {
        public Authors()
        {
            this.Books = new HashSet<Books>();
        }
    
        public int Author_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
    
        public virtual ICollection<Books> Books { get; set; }
    }
}
