//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eHMISWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EthioHIMS_QuarterOPDDiseaseView4
    {
        public int ID { get; set; }
        public string SNO { get; set; }
        public string Disease { get; set; }
        public Nullable<int> M04 { get; set; }
        public Nullable<int> M514 { get; set; }
        public Nullable<int> M15 { get; set; }
        public Nullable<int> F04 { get; set; }
        public Nullable<int> F514 { get; set; }
        public Nullable<int> F15 { get; set; }
        public Nullable<int> Format { get; set; }
        public Nullable<bool> userDefined { get; set; }
    }
}