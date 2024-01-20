using System.Collections.Generic;

namespace ServiceSearchActions.Core.Entites.Shares
{
    public class SummaryProfile : BaseEntity
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Sate { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Industry { get; set; }
        public string IndustryKey { get; set; }
        public string IndustryDisp { get; set; }
        public string Sector { get; set; }
        public string SectorKey { get; set; }
        public string SectorDisp { get; set; }
        public string LongBusinessSummary { get; set; }
        public int FullTimeEmployees { get; set; }
        public List<object> CompanyOfficers { get; set; }
    }
}
