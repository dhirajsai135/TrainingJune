//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqInventoryTask.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseOrderDetail
    {
        public int PODID { get; set; }
        public Nullable<int> OID { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> qty { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
