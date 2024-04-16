using System.Collections.Generic;

namespace ServiceSearchActions.Core.Entites.Shares
{
    public class CompanyProfile : BaseEntity
    {
        public CompanyProfile(string address1, string address2, string city, string sate, string zip, string country, string phone, string website, string industry, string industryKey, string industryDisp, string sector, string sectorKey, string sectorDisp, string longBusinessSummary, int fullTimeEmployees)
        {
            Address1 = address1;
            Address2 = address2;
            City = city;
            Sate = sate;
            Zip = zip;
            Country = country;
            Phone = phone;
            Website = website;
            Industry = industry;
            IndustryKey = industryKey;
            IndustryDisp = industryDisp;
            Sector = sector;
            SectorKey = sectorKey;
            SectorDisp = sectorDisp;
            LongBusinessSummary = longBusinessSummary;
            FullTimeEmployees = fullTimeEmployees;
        }

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
    }
}
