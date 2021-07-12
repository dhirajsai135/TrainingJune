﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BooksDBEntities : DbContext
    {
        public BooksDBEntities()
            : base("name=BooksDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<E_details> E_details { get; set; }
        public virtual DbSet<tbl_author> tbl_author { get; set; }
        public virtual DbSet<tbl_Books> tbl_Books { get; set; }
    
        public virtual ObjectResult<GetBooks_Result> GetBooks()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBooks_Result>("GetBooks");
        }
    
        public virtual int InsertBooks(Nullable<int> authorId, string bookName)
        {
            var authorIdParameter = authorId.HasValue ?
                new ObjectParameter("AuthorId", authorId) :
                new ObjectParameter("AuthorId", typeof(int));
    
            var bookNameParameter = bookName != null ?
                new ObjectParameter("BookName", bookName) :
                new ObjectParameter("BookName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertBooks", authorIdParameter, bookNameParameter);
        }
    
        public virtual int sp_InsBook(string title, Nullable<int> authorId, Nullable<decimal> price)
        {
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var authorIdParameter = authorId.HasValue ?
                new ObjectParameter("AuthorId", authorId) :
                new ObjectParameter("AuthorId", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsBook", titleParameter, authorIdParameter, priceParameter);
        }
    }
}
