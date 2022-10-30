namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2941 : JsonType1
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
        public float[] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string ObjectName { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string ObjectAddress { get; set; }
        public string Coordinates { get; set; }
        public string ConsrtuctionWorkType { get; set; }
        public string MainFunctional { get; set; }
        public string SourceOfFinance { get; set; }
        public float? DevelopmentArea { get; set; }
        public string FloorsAmount { get; set; }
        public string ObjectStatus { get; set; }
        public string CadastralNumber { get; set; }
        public string AreaCoordinates { get; set; }
        public string GpzuDocumentNumber { get; set; }
        public string GpzuDocumentDate { get; set; }
        public string GpzuDocumentStatus { get; set; }
        public string EntryState { get; set; }
        public long GlobalId { get; set; }
        public int DeveloperInfoisdeleted0 { get; set; }
        public int DeveloperInfoGlobalId0 { get; set; }
        public string DeveloperInfoOrgForm0 { get; set; }
        public string DeveloperInfoOrgName0 { get; set; }
        public int DeveloperInfoisdeleted1 { get; set; }
        public int DeveloperInfoGlobalId1 { get; set; }
        public object DeveloperInfoOrgForm1 { get; set; }
        public string DeveloperInfoOrgName1 { get; set; }
        public int Permissionisdeleted0 { get; set; }
        public int PermissionGlobalId0 { get; set; }
        public string PermissionPermissionNumber0 { get; set; }
        public string PermissionPermissionBeginDate0 { get; set; }
        public string PermissionPermissionEndDate0 { get; set; }
        public string PermissionPermissionStatus0 { get; set; }
        public Permissionpermissionfile0[] PermissionPermissionFile0 { get; set; }
        public int Permissionisdeleted1 { get; set; }
        public int PermissionGlobalId1 { get; set; }
        public string PermissionPermissionNumber1 { get; set; }
        public string PermissionPermissionBeginDate1 { get; set; }
        public string PermissionPermissionEndDate1 { get; set; }
        public string PermissionPermissionStatus1 { get; set; }
        public Permissionpermissionfile1[] PermissionPermissionFile1 { get; set; }
        public int Permissionisdeleted2 { get; set; }
        public int PermissionGlobalId2 { get; set; }
        public string PermissionPermissionNumber2 { get; set; }
        public string PermissionPermissionBeginDate2 { get; set; }
        public string PermissionPermissionEndDate2 { get; set; }
        public string PermissionPermissionStatus2 { get; set; }
        public object[] PermissionPermissionFile2 { get; set; }
        public int Permissionisdeleted3 { get; set; }
        public int PermissionGlobalId3 { get; set; }
        public string PermissionPermissionNumber3 { get; set; }
        public string PermissionPermissionBeginDate3 { get; set; }
        public string PermissionPermissionEndDate3 { get; set; }
        public string PermissionPermissionStatus3 { get; set; }
        public object[] PermissionPermissionFile3 { get; set; }
        public int Permissionisdeleted4 { get; set; }
        public int PermissionGlobalId4 { get; set; }
        public string PermissionPermissionNumber4 { get; set; }
        public string PermissionPermissionBeginDate4 { get; set; }
        public string PermissionPermissionEndDate4 { get; set; }
        public string PermissionPermissionStatus4 { get; set; }
        public Permissionpermissionfile4[] PermissionPermissionFile4 { get; set; }
        public int Permissionisdeleted5 { get; set; }
        public int PermissionGlobalId5 { get; set; }
        public string PermissionPermissionNumber5 { get; set; }
        public string PermissionPermissionBeginDate5 { get; set; }
        public string PermissionPermissionEndDate5 { get; set; }
        public object PermissionPermissionStatus5 { get; set; }
        public Permissionpermissionfile5[] PermissionPermissionFile5 { get; set; }
        public int Permissionisdeleted6 { get; set; }
        public int PermissionGlobalId6 { get; set; }
        public string PermissionPermissionNumber6 { get; set; }
        public string PermissionPermissionBeginDate6 { get; set; }
        public string PermissionPermissionEndDate6 { get; set; }
        public object PermissionPermissionStatus6 { get; set; }
        public Permissionpermissionfile6[] PermissionPermissionFile6 { get; set; }
        public int Permissionisdeleted7 { get; set; }
        public int PermissionGlobalId7 { get; set; }
        public string PermissionPermissionNumber7 { get; set; }
        public string PermissionPermissionBeginDate7 { get; set; }
        public string PermissionPermissionEndDate7 { get; set; }
        public object PermissionPermissionStatus7 { get; set; }
        public object[] PermissionPermissionFile7 { get; set; }
        public int Permissionisdeleted8 { get; set; }
        public int PermissionGlobalId8 { get; set; }
        public string PermissionPermissionNumber8 { get; set; }
        public string PermissionPermissionBeginDate8 { get; set; }
        public string PermissionPermissionEndDate8 { get; set; }
        public object PermissionPermissionStatus8 { get; set; }
        public object[] PermissionPermissionFile8 { get; set; }
        public int Permissionisdeleted9 { get; set; }
        public int PermissionGlobalId9 { get; set; }
        public string PermissionPermissionNumber9 { get; set; }
        public string PermissionPermissionBeginDate9 { get; set; }
        public string PermissionPermissionEndDate9 { get; set; }
        public object PermissionPermissionStatus9 { get; set; }
        public object[] PermissionPermissionFile9 { get; set; }
    }

    public class Permissionpermissionfile0
    {
        public int Isdeleted { get; set; }
        public int GlobalId { get; set; }
        public string PermissionFile { get; set; }
    }

    public class Permissionpermissionfile1
    {
        public int Isdeleted { get; set; }
        public int GlobalId { get; set; }
        public string PermissionFile { get; set; }
    }

    public class Permissionpermissionfile4
    {
        public int Isdeleted { get; set; }
        public int GlobalId { get; set; }
        public string PermissionFile { get; set; }
    }

    public class Permissionpermissionfile5
    {
        public int Isdeleted { get; set; }
        public int GlobalId { get; set; }
        public string PermissionFile { get; set; }
    }

    public class Permissionpermissionfile6
    {
        public int Isdeleted { get; set; }
        public int GlobalId { get; set; }
        public string PermissionFile { get; set; }
    }

}