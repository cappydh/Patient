//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Diseases
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public string Disease { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public bool Active { get; set; }
    
        public virtual Patients Patients { get; set; }
    }
}
