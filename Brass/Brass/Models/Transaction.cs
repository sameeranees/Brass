//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Brass.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int id { get; set; }
        public double totalAmount { get; set; }
        public Nullable<int> salesTax { get; set; }
        public string description { get; set; }
        public string account { get; set; }
        public System.DateTime date { get; set; }
        public string personName { get; set; }
        public string vehicleNumber { get; set; }
        public Nullable<bool> paymentPaid { get; set; }
        public Nullable<bool> paymentReceived { get; set; }
        public Nullable<bool> expense { get; set; }
        public Nullable<bool> loanPayable { get; set; }
        public Nullable<bool> loanReceivable { get; set; }
        public Nullable<int> category { get; set; }
        public Nullable<int> customerId { get; set; }
        public Nullable<int> vendorId { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
