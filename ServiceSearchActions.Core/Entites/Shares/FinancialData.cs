using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSearchActions.Core.Entites.Shares
{
    public class FinancialData : BaseEntity
    {
        public double CurrentPrice { get; set; }
        public int TargetHighPrice { get; set; }
        public int TargetLowPrice { get; set; }
        public double TargetMeanPrice { get; set; }
        public double TargetMedianPrice { get; set; }
        public double RecommendationMean { get; set; }
        public string RecommendationKey { get; set; }
        public int NumberOfAnalystOpinions { get; set; }
        public long TotalCash { get; set; }
        public double TotalCashPerShare { get; set; }
        public long Ebitda { get; set; }
        public long TotalDebt { get; set; }
        public double QuickRatio { get; set; }
        public double CurrentRatio { get; set; }
        public long TotalRevenue { get; set; }
        public double DebtToEquity { get; set; }
        public double RevenuePerShare { get; set; }
        public double ReturnOnAssets { get; set; }
        public double ReturnOnEquity { get; set; }
        public long GrossProfits { get; set; }
        public long FreeCashflow { get; set; }
        public long OperatingCashflow { get; set; }
        public double EarningsGrowth { get; set; }
        public double RevenueGrowth { get; set; }
        public double GrossMargins { get; set; }
        public double EbitdaMargins { get; set; }
        public double OperatingMargins { get; set; }
        public double ProfitMargins { get; set; }
        public string FinancialCurrency { get; set; }
    }
    public class Root
    {
        public FinancialData financialData { get; set; }
    }
}
