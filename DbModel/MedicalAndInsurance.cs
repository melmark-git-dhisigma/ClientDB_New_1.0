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
    
    public partial class MedicalAndInsurance
    {
        public int MedicalInsuranceId { get; set; }
        public int StudentPersonalId { get; set; }
        public int SchoolId { get; set; }
        public Nullable<int> AddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Speciality { get; set; }
        public string City { get; set; }
        public string OfficePhone { get; set; }
        public Nullable<System.DateTime> DateOfLastPhysicalExam { get; set; }
        public string MedicalConditionsDiagnosis { get; set; }
        public string Allergies { get; set; }
        public string CurrentMedications { get; set; }
        public string SelfPreservationAbility { get; set; }
        public string SignificantBehaviorCharacteristics { get; set; }
        public string Capabilities { get; set; }
        public string Limitations { get; set; }
        public string Preferances { get; set; }
        public Nullable<int> PhysicianId { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> StateId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
