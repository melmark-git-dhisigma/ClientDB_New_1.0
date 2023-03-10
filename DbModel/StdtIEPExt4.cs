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
    
    public partial class StdtIEPExt4
    {
        public StdtIEPExt4()
        {
            this.StdtIEPExt5 = new HashSet<StdtIEPExt5>();
        }
    
        public int StdtIEPId { get; set; }
        public string SigRoleLEARep { get; set; }
        public Nullable<System.DateTime> SigRep_date { get; set; }
        public Nullable<bool> ParntAccptIEP { get; set; }
        public Nullable<bool> ParntRejctIEP { get; set; }
        public Nullable<bool> ParntDontRejctIEP { get; set; }
        public string ParntDontRejctDesc { get; set; }
        public Nullable<bool> ParntReqMeetig { get; set; }
        public string SigParnt { get; set; }
        public Nullable<System.DateTime> SigParnt_date { get; set; }
        public string ParntComnt { get; set; }
        public Nullable<bool> PoMEliDeter { get; set; }
        public Nullable<bool> PoMInitEval { get; set; }
        public Nullable<bool> PoMReeval { get; set; }
        public Nullable<bool> PoMIEPDev { get; set; }
        public Nullable<bool> PoMInit { get; set; }
        public Nullable<bool> PoMAnnRev { get; set; }
        public Nullable<bool> PoMOtherCheck { get; set; }
        public string PoMOtherText { get; set; }
        public Nullable<bool> PoMPlacement { get; set; }
        public string Role { get; set; }
        public string LanguageofInst { get; set; }
        public Nullable<bool> ActonOwnBehalfCk { get; set; }
        public Nullable<bool> CourtAppGrdCk { get; set; }
        public Nullable<bool> SharedDecMakingCk { get; set; }
        public Nullable<bool> DelegateDeciMakCk { get; set; }
        public string CourtAppGuardian { get; set; }
        public string PrLanguageGrd1 { get; set; }
        public string PrLanguageGrd2 { get; set; }
        public Nullable<System.DateTime> DateOfMeeting { get; set; }
        public string TypeOfMeeting { get; set; }
        public string AnnualReviewMeeting { get; set; }
        public string ReevaluationMeeting { get; set; }
        public Nullable<bool> CostSharedPnt { get; set; }
        public string SpecifyAgency { get; set; }
        public Nullable<bool> PlOneEarlyPgm { get; set; }
        public Nullable<bool> PlOneSeparatePgm { get; set; }
        public string PlOneBothPgm { get; set; }
        public string PlOneServiceLocation { get; set; }
        public string PlOneServiceLocation2 { get; set; }
        public string PlOneHoursWkPgm { get; set; }
        public Nullable<bool> PlOneEnrolledPrnt { get; set; }
        public Nullable<bool> PlOnePlcdTeam { get; set; }
        public Nullable<bool> PlOneTimeMore { get; set; }
        public Nullable<bool> PlOneTimeTwo { get; set; }
        public Nullable<bool> PlOneTimeThree { get; set; }
        public Nullable<bool> PlOneSeparateClass { get; set; }
        public Nullable<bool> PlOneSeparateDayScl { get; set; }
        public Nullable<bool> PlOneSeparatePublic { get; set; }
        public Nullable<bool> PlOneSeparatePvt { get; set; }
        public Nullable<bool> PlOneResidentialFacility { get; set; }
        public Nullable<bool> PlOneHome { get; set; }
        public Nullable<bool> PlOneServiceLctn { get; set; }
        public Nullable<bool> PlOnePsychiatric { get; set; }
        public Nullable<bool> PlOneMassachusetts { get; set; }
        public Nullable<bool> PlOneMassachusettsDay { get; set; }
        public Nullable<bool> PlOneMassachusettsRes { get; set; }
        public Nullable<bool> PlOneDoctorHme { get; set; }
        public Nullable<bool> PlOneDoctorHsptl { get; set; }
        public Nullable<bool> PlOneConsent { get; set; }
        public Nullable<bool> PlOneRefuse { get; set; }
        public Nullable<bool> PlOnePlacement { get; set; }
        public string PlOneSignParent { get; set; }
        public Nullable<System.DateTime> PlOneDate { get; set; }
        public Nullable<bool> PlTwoFullInclusionPgm { get; set; }
        public Nullable<bool> PlTwoPartialPgm { get; set; }
        public Nullable<bool> PlTwoSubstantially { get; set; }
        public Nullable<bool> PlTwoSeparateScl { get; set; }
        public Nullable<bool> PlTwoPublicScl { get; set; }
        public Nullable<bool> PlTwoPrivateScl { get; set; }
        public Nullable<bool> PlTwoYouth { get; set; }
        public Nullable<bool> PlTwoResScl { get; set; }
        public Nullable<bool> PlTwoOther { get; set; }
        public string PlTwoOtherDesc { get; set; }
        public Nullable<bool> PlTwoPsychiatric { get; set; }
        public Nullable<bool> PlTwoMassachusetts { get; set; }
        public Nullable<bool> PlTwoMassachusettsDay { get; set; }
        public Nullable<bool> PltwoMassachusettsRes { get; set; }
        public Nullable<bool> PlTwoCorrectionFacility { get; set; }
        public Nullable<bool> PlTwoDoctorHome { get; set; }
        public Nullable<bool> PlTwoDoctorHsptl { get; set; }
        public Nullable<bool> PlTwoConsent { get; set; }
        public Nullable<bool> PlTwoPlacement { get; set; }
        public string PlTwoSignParent { get; set; }
        public Nullable<System.DateTime> PlTwoDate { get; set; }
        public Nullable<bool> PlTwoFullPgm { get; set; }
        public Nullable<int> StatusId { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }
        public string RoleDesc { get; set; }
        public Nullable<System.DateTime> AtndDate { get; set; }
        public string SchAddress { get; set; }
        public string SchContact { get; set; }
        public string SchoolName { get; set; }
        public string SchoolPhone { get; set; }
        public string SchTelephone { get; set; }
    
        public virtual ICollection<StdtIEPExt5> StdtIEPExt5 { get; set; }
    }
}
