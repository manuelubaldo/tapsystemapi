//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RESTfulAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCity
    {
        public int iCityID { get; set; }
        public string tCityName { get; set; }
        public string tCreatedBy { get; set; }
        public Nullable<System.DateTime> dDateCreated { get; set; }
        public string tModifiedBy { get; set; }
        public Nullable<System.DateTime> dDateModified { get; set; }
        public int bActive { get; set; }
    }
}
