
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
    
public partial class UserLevel
{

    public string UserID { get; set; }

    public System.Guid CategoryID { get; set; }

    public int Level { get; set; }

    public System.DateTime Obtained { get; set; }

    public Nullable<decimal> XP { get; set; }



    public virtual AspNetUser AspNetUser { get; set; }

    public virtual Category Category { get; set; }

}

}
