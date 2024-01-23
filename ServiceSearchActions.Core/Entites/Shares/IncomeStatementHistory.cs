using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSearchActions.Core.Entites.Shares
{
    public class IncomeStatementHistory : BaseEntity
    {
        public List<IncomeStatementHistory> incomeStatementHistory { get; set; }
        public DateTime EndDate { get; set; }
        public long TotalRevenue { get; set; }
        public long CostOfRevenue { get; set; }
        public long GrossProfit { get; set; }
        public long ResearchDevelopment { get; set; }
        public long SellingGeneralAdministrative { get; set; }
        public object NonRecurring { get; set; }
        public int OtherOperatingExpenses { get; set; }
        public long TotalOperatingExpenses { get; set; }
        public long OperatingIncome { get; set; }
        public int TotalOtherIncomeExpenseNet { get; set; }
        public long Ebit { get; set; }
        public int InterestExpense { get; set; }
        public long IncomeBeforeTax { get; set; }
        public long IncomeTaxExpense { get; set; }
        public int MinorityInterest { get; set; }
        public long NetIncomeFromContinuingOps { get; set; }
        public object DiscontinuedOperations { get; set; }
        public object ExtraordinaryItems { get; set; }
        public object EffectOfAccountingCharges { get; set; }
        public object OtherItems { get; set; }
        public long NetIncome { get; set; }
        public long NetIncomeApplicableToCommonShares { get; set; }
    }
}
