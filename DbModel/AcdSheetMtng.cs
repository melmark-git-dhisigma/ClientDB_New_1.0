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
    
    public partial class AcdSheetMtng
    {
        public int MtngId { get; set; }
        public Nullable<int> AccSheetId { get; set; }
        public Nullable<int> LessonPlanId { get; set; }
        public string PropAndDisc { get; set; }
        public Nullable<int> PersonResp { get; set; }
        public Nullable<System.DateTime> Deadlines { get; set; }
        public string ActiveInd { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
