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
    using System.Collections.Generic;
    
    public partial class Answer
    {
        public System.Guid ID { get; set; }
        public string UserID { get; set; }
        public System.Guid QuestionID { get; set; }
        public string Description { get; set; }
        public Nullable<int> Score { get; set; }
        public System.DateTime Added { get; set; }
    }
}
