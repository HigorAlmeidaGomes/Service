using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSearchActions.Core.Entites.Shares
{
    public class IncomeStatementHistory : BaseEntity
    {
        public DateTime EndDate { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal CostOfRevenue { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal ResearchDevelopment { get; set; }
        public decimal SellingGeneralAdministrative { get; set; }
        public string NonRecurring { get; set; }
        public decimal OtherOperatingExpenses { get; set; }
        public decimal TotalOperatingExpenses { get; set; }
        public decimal OperatingIncome { get; set; }
        public decimal TotalOtherIncomeExpenseNet { get; set; }
        public decimal Ebit { get; set; }
        public decimal InterestExpense { get; set; }
        public decimal IncomeBeforeTax { get; set; }
        public decimal IncomeTaxExpense { get; set; }
        public decimal MinorityInterest { get; set; }
        public decimal NetIncomeFromContinuingOps { get; set; }
        public string DiscontinuedOperations { get; set; }
        public string ExtraordinaryItems { get; set; }
        public string EffectOfAccountingCharges { get; set; }
        public string OtherItems { get; set; }
        public decimal NetIncome { get; set; }
        public decimal NetIncomeApplicableToCommonShares { get; set; }
    }
}
