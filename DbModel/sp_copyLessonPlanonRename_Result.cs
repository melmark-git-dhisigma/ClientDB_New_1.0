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
    
    public partial class sp_copyLessonPlanonRename_Result
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public string LessonType { get; set; }
        public Nullable<int> DomainId { get; set; }
        public Nullable<int> NmbrSet { get; set; }
        public Nullable<int> NmbrStep { get; set; }
        public string IsDiscreate { get; set; }
        public Nullable<bool> IsST_Edit { get; set; }
        public Nullable<bool> IsCC_Edit { get; set; }
        public string OwnerName { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}