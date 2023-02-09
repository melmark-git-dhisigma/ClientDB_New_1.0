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
    
    public partial class StdtSessionScore
    {
        public int StdtSessScoreId { get; set; }
        public Nullable<int> SchoolId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<int> LessonPlanId { get; set; }
        public Nullable<int> MeasurementId { get; set; }
        public string SessEventType { get; set; }
        public Nullable<System.DateTime> LoadDate { get; set; }
        public string PercentageScore { get; set; }
        public string CorrRespCount { get; set; }
        public string TotalTrial { get; set; }
        public string PercIndependent { get; set; }
        public string PercPrompt { get; set; }
        public string PercAccuracy { get; set; }
        public string TotalDuration { get; set; }
        public string AvgDuration { get; set; }
        public string Frequency { get; set; }
        public string Custom { get; set; }
        public Nullable<int> MajorScr { get; set; }
        public Nullable<int> MinorScr { get; set; }
        public string IOAPerc { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }
}
