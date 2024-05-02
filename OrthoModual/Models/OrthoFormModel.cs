namespace OrthoModual.Models
{
    public class OrthoFormModel
    {
        public PersnolDetails persnolDetails { get; set; }
        public TreatmentRecieved treatmentRecieved { get; set; }
        public TreatmentGiven treatmentGiven { get; set; }
        public GPTreatmentGiven pTreatmentGiven { get; set; }
        public InjuriesSustained injuriesSustained { get; set; }
        public AffectOnWork affectOnWork { get; set; }
        public AffectOnSocial affectOnSocial { get; set; }
        public AssociatePhychologicalSymptoms associatePhychologicalSymptoms { get; set; }
        public MedicalHistory medicalHistory { get; set; }
        public Examination examination { get; set; }
        public Recomendation recomendation { get; set; }
        public IList<KeyValueModel> titleKeyValueModels { get; set; }
        public IList<KeyValueModel> initialKeyValueModels { get; set; }
        public IList<KeyValueModel> InjuryTypeKeyValueModels { get; set; }
        public IList<KeyValueModel> OngoingTypeKeyValueModels { get; set; }
        public IList<KeyValueModel> PhotoIdKeyValueModels { get; set; }
        public IList<KeyValueModel> GaitTypeKeyValueModels { get; set; }
        public IList<KeyValueModel> PostureKeyValueModels { get; set; }
        public IList<KeyValueModel> NoOfSessionKeyValueModels { get; set; }
        public IList<KeyValueModel> RefferdKeyValueModels { get; set; }

    }

    public class PersnolDetails
    {
        public int? clientRef { get; set; }
        public string? solicitorRef { get; set; }
        public string? medcoRef { get; set; }
        public string? examinationDate { get; set; }
        public int? title { get; set; }
        public string? gender { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? middleName { get; set; }
        public string? accompaniedBy { get; set; }
        public string? address { get; set; }
        public string? town { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public string? country { get; set; }
        public string? occupation { get; set; }
        public string? postCode { get; set; }
        public DateTime? accidentdate { get; set; }
        public string? typeOfIncident { get; set; }
        public string? typeOfOccupency { get; set; }
        public string? thirdPartyVehical { get; set; }
        public string? totalOfOccupant { get; set; }
        public string? isSeatBeltWearing { get; set; }
        public string? seatBeltDescription { get; set; }
        public bool? isPoliceAttendScene { get; set; }
        public bool? isVehicalMoving { get; set; }
        public int? vehicalSpeed { get; set; }
        public string? accidentHistory { get; set; }
    }

    public class TreatmentRecieved
    {
        public bool? isAmbulanceattend { get; set; }
        public bool? isAmbulanceTakeToHospitle { get; set; }
        public string? visitedHospitleType { get; set; }
        public string? timeOfVisitedHospital { get; set; }
        public string? hospitalName { get; set; }
        public bool? isGPVisited { get; set; }
        public string? timeOfGPVisited { get; set; }
        public bool? isPhysiotherapyRecived { get; set; }
        public int? physiotherapyNoOfSession { get; set; }
        public bool? isPainKillerTaken { get; set; }
        public string? painKillerDescription { get; set; }
    }

    public class TreatmentGiven
    {
        public bool? isPainkiller { get; set; }
        public string? painkillerDescription { get; set; }
        public bool? isAdvice { get; set; }
        public string? adviceDescription { get; set; }
        public bool? isRecomendation { get; set; }
        public string? recomendationDescription { get; set; }
    }

    public class GPTreatmentGiven
    {
        public bool? isPainkiller { get; set; }
        public string? painkillerDescription { get; set; }
        public bool? isAdvice { get; set; }
        public string? adviceDescription { get; set; }
        public bool? isRecomendation { get; set; }
        public string? recomendationDescription { get; set; }
    }

    public class InjuriesSustained
    {
        public int? injury { get; set; }
        public int? initial { get; set; }
        public string? isInjuryResolved { get; set; }
        public bool? injuryResolvedDescription { get; set; }
        public int? onGoing { get; set; }
        public string? specialNote { get; set; }

    }

    public class AffectOnWork
    {
        public bool? isTimeWorkOff { get; set; }
        public string? workOffperiod { get; set; }
        public bool? isSiceNote { get; set; }
        public string? sicePeriod { get; set; }
        public string? changeOfJob { get; set; }
        public bool? isbackTowork { get; set; }
        public string? specialNote { get; set; }
    }

    public class AffectOnSocial
    {
        public bool? personalHygiene { get; set; }
        public bool? cookingWashing { get; set; }
        public bool? lookingAfterChildren { get; set; }
        public bool? gardening { get; set; }
        public bool? sportActivity { get; set; }
        public string? sportActivityDescription { get; set; }
        public string? specialNote { get; set; }
    }
    
    public class AssociatePhychologicalSymptoms
    {
        public string? distrubedSleep { get; set;}
        public string? distrubedSleepDescription { get; set;}
        public string? travelDiscomfort { get; set;}
        public string? travelDiscomfortDescription { get; set;}
        public string? travelAnxienty { get; set;}
        public string? travelAnxientyDescription { get; set;}
        public string? loseOfAppetite { get; set;}
        public string? loseOfAppetiteDescription { get; set;}
        public string? flashback { get; set;}
        public string? flashbackDescription { get; set;}
        public string? nightmares { get; set;}
        public string? nightmaresDescription { get; set;}
        public string? ongoingSymptoms { get; set;}
        public string? specialNote { get; set;}
    }

    public class MedicalHistory
    {
        public bool? pastAccident { get; set;}
        public string? pastAccidentDescription { get; set;}
        public bool? pastAccidentRelatedThisAccident { get; set;}
        public string? pastAccidentRelatedThisAccidentDescription { get; set;}
    }

    public class Examination
    {
        public int? photoId { get;set;}
        public int? gaitId { get;set;}
        public int? postureId { get;set;}
        public string? otherID { get;set;}
        public bool? isWorkOffOfMedicalExpertOpinion { get;set;}
    }
    public class Recomendation
    {
        public bool? isPhysiotherapy { get;set;}
        public bool? isRefferd { get;set;}
        public int? refferdId { get;set;}
        public int? noOfSessionId { get;set;}
    }

    public class KeyValueModel
    {
        public int? KeyId { get; set;}
        public string? KeyValue { get; set;}
    }

}
