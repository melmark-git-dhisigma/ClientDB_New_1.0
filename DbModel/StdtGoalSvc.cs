//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientDB.DbModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class StdtGoalSvc
    {
        public int StdtGoalSvcId { get; set; }
        public string StdtGoalId { get; set; }
        public Nullable<int> StdtIEPId { get; set; }
        public string SvcDelTyp { get; set; }
        public string SvcTypDesc { get; set; }
        public string PersonalTypDesc { get; set; }
        public string FreqDurDesc { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
