using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSearchActions.Core.Entites.Shares
{
    public class BalanceSheetHistory
    {
        public DateTime EndDate { get; set; }
        public long Cash { get; set; }
        public long ShortTermInvestments { get; set; }
        public long NetReceivables { get; set; }
        public long Inventory { get; set; }
        public long OtherCurrentAssets { get; set; }
        public long TotalCurrentAssets { get; set; }
        public long LongTermInvestments { get; set; }
        public long PropertyPlantEquipment { get; set; }
        public int GoodWill { get; set; }
        public long IntangibleAssets { get; set; }
        public long OtherAssets { get; set; }
        public long DeferredLongTermAssetCharges { get; set; }
        public long TotalAssets { get; set; }
        public long AccountsPayable { get; set; }
        public long ShortLongTermDebt { get; set; }
        public long OtherCurrentLiab { get; set; }
        public long LongTermDebt { get; set; }
        public long OtherLiab { get; set; }
        public int MinorityInterest { get; set; }
        public long TotalCurrentLiabilities { get; set; }
        public long TotalLiab { get; set; }
        public long CommonStock { get; set; }
        public long RetainedEarnings { get; set; }
        public long TreasuryStock { get; set; }
        public long OtherStockholderEquity { get; set; }
        public long TotalStockholderEquity { get; set; }
        public long NetTangibleAssets { get; set; }
    }
}
