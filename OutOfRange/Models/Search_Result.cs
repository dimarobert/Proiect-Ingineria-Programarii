//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OutOfRange.Models
{
    using System;
    
    public partial class Search_Result
    {
        public Nullable<System.Guid> ID { get; set; }
        public string UserID { get; set; }
        public Nullable<System.Guid> CategoryID { get; set; }
        public string Title { get; set; }
        public string QuestionBody { get; set; }
        public Nullable<System.DateTime> Added { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public Nullable<decimal> Score { get; set; }
        public Nullable<decimal> Bounty { get; set; }
        public Nullable<int> Rank { get; set; }
    }
}
