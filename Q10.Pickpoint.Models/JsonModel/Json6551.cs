namespace Q10.Pickpoint.Models.JsonModel;

public class Json6551
{
    public Feature[] Features { get; set; }
    public string Type { get; set; }

    public class Feature
    {
        public Geometry Geometry { get; set; }
        public Properties Properties { get; set; }
        public string Type { get; set; }
    }

    public class Geometry
    {
        public float[][] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string Categoryen { get; set; }
        public string CommonNameen { get; set; }
        public string FullNameen { get; set; }
        public string ShortNameen { get; set; }
        public string ChiefPositionen { get; set; }
        public string ChiefNameen { get; set; }
        public string ClarificationWorkingHoursen { get; set; }
        public string WebSiteen { get; set; }
        public long GlobalId { get; set; }
        public int OrgInfoenisdeleted0 { get; set; }
        public string OrgInfoenFullNameen0 { get; set; }
        public string OrgInfoenInNen0 { get; set; }
        public string OrgInfoenKpPen0 { get; set; }
        public string OrgInfoenOgrNen0 { get; set; }
        public string OrgInfoenLegalAddressen0 { get; set; }
        public string OrgInfoenChiefNameen0 { get; set; }
        public string OrgInfoenChiefPositionen0 { get; set; }
        public OrginfoEnchiefphoneEn0[] OrgInfoenChiefPhoneen0 { get; set; }
        public int OrgInfoenGlobalId0 { get; set; }
        public int ObjectAddressenisdeleted0 { get; set; }
        public string ObjectAddressenAdmAreaen0 { get; set; }
        public string ObjectAddressenDistricten0 { get; set; }
        public string ObjectAddressenPostalCodeen0 { get; set; }
        public string ObjectAddressenAddressen0 { get; set; }
        public string ObjectAddressenSocialServicesen0 { get; set; }
        public ObjectaddressEnavailabilityEn0[] ObjectAddressenAvailabilityen0 { get; set; }
        public int ObjectAddressenGlobalId0 { get; set; }
        public int PublicPhoneenisdeleted0 { get; set; }
        public string PublicPhoneenPublicPhoneen0 { get; set; }
        public int PublicPhoneenGlobalId0 { get; set; }
        public int WorkingHoursenisdeleted0 { get; set; }
        public string WorkingHoursenDayWeeken0 { get; set; }
        public string WorkingHoursenWorkHoursen0 { get; set; }
        public int WorkingHoursenGlobalId0 { get; set; }
        public int WorkingHoursenisdeleted1 { get; set; }
        public string WorkingHoursenDayWeeken1 { get; set; }
        public string WorkingHoursenWorkHoursen1 { get; set; }
        public int WorkingHoursenGlobalId1 { get; set; }
        public int WorkingHoursenisdeleted2 { get; set; }
        public string WorkingHoursenDayWeeken2 { get; set; }
        public string WorkingHoursenWorkHoursen2 { get; set; }
        public int WorkingHoursenGlobalId2 { get; set; }
        public int WorkingHoursenisdeleted3 { get; set; }
        public string WorkingHoursenDayWeeken3 { get; set; }
        public string WorkingHoursenWorkHoursen3 { get; set; }
        public int WorkingHoursenGlobalId3 { get; set; }
        public int WorkingHoursenisdeleted4 { get; set; }
        public string WorkingHoursenDayWeeken4 { get; set; }
        public string WorkingHoursenWorkHoursen4 { get; set; }
        public int WorkingHoursenGlobalId4 { get; set; }
        public int WorkingHoursenisdeleted5 { get; set; }
        public string WorkingHoursenDayWeeken5 { get; set; }
        public string WorkingHoursenWorkHoursen5 { get; set; }
        public int WorkingHoursenGlobalId5 { get; set; }
        public int WorkingHoursenisdeleted6 { get; set; }
        public string WorkingHoursenDayWeeken6 { get; set; }
        public string WorkingHoursenWorkHoursen6 { get; set; }
        public int WorkingHoursenGlobalId6 { get; set; }
        public int PublicPhoneenisdeleted1 { get; set; }
        public string PublicPhoneenPublicPhoneen1 { get; set; }
        public int PublicPhoneenGlobalId1 { get; set; }
    }

    public class OrginfoEnchiefphoneEn0
    {
        public int Isdeleted { get; set; }
        public int GlobalId { get; set; }
        public string ChiefPhoneen { get; set; }
    }

    public class ObjectaddressEnavailabilityEn0
    {
        public int Isdeleted { get; set; }
        public int GlobalId { get; set; }
        public string Availableken { get; set; }
        public string Availableoen { get; set; }
        public string Availablezen { get; set; }
        public string Availablesen { get; set; }
        public AvailableElementEn[] Availableelementen { get; set; }
    }

    public class AvailableElementEn
    {
        public int Isdeleted { get; set; }
        public int GlobalId { get; set; }
        public string Groupmgnen { get; set; }
        public string Areamgnen { get; set; }
        public string Elementmgnen { get; set; }
        public string Availabledegreeen { get; set; }
        public string Availableindexen { get; set; }
    }

}