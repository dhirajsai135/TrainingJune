//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BooksEFDropDown.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Books
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual tbl_author tbl_author { get; set; }
    }
}
