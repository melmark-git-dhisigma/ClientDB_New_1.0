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
    
    public partial class SelectStudentPersonalDetails_Result
    {
        public int StudentPersonalId { get; set; }
        public string studentPersonalName { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<System.DateTime> AdmissionDate { get; set; }
        public string PlaceOfBirth { get; set; }
        public Nullable<int> StateOfBirth { get; set; }
        public Nullable<int> CountryOfBirth { get; set; }
        public string CountryOfCitizenship { get; set; }
        public Nullable<int> MaritalStatus { get; set; }
        public string PrimaryLanguage { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Weight { get; set; }
    }
}
