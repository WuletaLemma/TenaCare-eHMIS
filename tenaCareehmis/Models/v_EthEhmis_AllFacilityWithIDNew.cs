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
    
    public partial class v_EthEhmis_AllFacilityWithIDNew
    {
        public int DistrictId { get; set; }
        public Nullable<byte> FacilityTypeId { get; set; }
        public string FacilityTypeName { get; set; }
        public string HMISCode { get; set; }
        public string FacilityName { get; set; }
        public int HealthCenterID { get; set; }
        public string HealthCenterName { get; set; }
        public int WoredaId { get; set; }
        public string WoredaName { get; set; }
        public Nullable<int> ZoneId { get; set; }
        public string ZONENAME { get; set; }
        public Nullable<int> RegionId { get; set; }
        public string ReportingRegionName { get; set; }
        public string ReportingAdminSite { get; set; }
        public Nullable<int> ReportingDistrictId { get; set; }
        public int reportingFacilityTypeId { get; set; }
    }
}
