namespace FMS_API.Models
{
    public class VM_OIM
    {
        //Master
        public string F_MBLNo { get; set; }
        public int? F_Shipper { get; set; }
        public string? F_SName { get; set; }
        public int? F_Consignee { get; set; }
        public string? F_CName { get; set; }

        //House
        public string F_HBLNo { get; set; }
        public string F_RefNo { get; set; }
    }
}
