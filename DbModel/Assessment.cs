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
    
    public partial class Assessment
    {
        public int AsmntId { get; set; }
        public int SchoolId { get; set; }
        public string AsmntName { get; set; }
        public string AsmntTemplateName { get; set; }
        public string AsmntDesc { get; set; }
        public byte[] AsmntXML { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> AsmntYearId { get; set; }
        public Nullable<int> AssignedUserId { get; set; }
        public Nullable<int> OrigAsmntId { get; set; }
        public string AsmntTyp { get; set; }
        public Nullable<int> AsmntStatusId { get; set; }
        public Nullable<System.DateTime> AsmntStartTs { get; set; }
        public Nullable<System.DateTime> AsmntEndTs { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> EffStartDate { get; set; }
        public Nullable<System.DateTime> EffEndDate { get; set; }
        public string ActiveInd { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
