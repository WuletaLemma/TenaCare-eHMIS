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
    
    public partial class EthEhmis_HMISValue
    {
        public int ValueID { get; set; }
        public int LabelID { get; set; }
        public int DataEleClass { get; set; }
        public int FederalID { get; set; }
        public int RegionID { get; set; }
        public int ZoneID { get; set; }
        public int WoredaID { get; set; }
        public string LocationID { get; set; }
        public int Week { get; set; }
        public int Month { get; set; }
        public int Quarter { get; set; }
        public int Year { get; set; }
        public decimal Value { get; set; }
        public int Level { get; set; }
        public int FACILITTYPE { get; set; }
        public System.DateTime DateEntered { get; set; }
        public bool Editable { get; set; }
    }
}