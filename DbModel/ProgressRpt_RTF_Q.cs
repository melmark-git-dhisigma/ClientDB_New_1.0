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
    
    public partial class ProgressRpt_RTF_Q
    {
        public int RTFQId { get; set; }
        public int SchoolId { get; set; }
        public int StudentId { get; set; }
        public int ProReportId { get; set; }
        public string RTF_Q_BLStart { get; set; }
        public string RTF_Q_BLEnd { get; set; }
        public string RTF_Q_RptDate { get; set; }
        public string RTF_Q_TBehavior { get; set; }
        public string RTF_Q_Outlines { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
