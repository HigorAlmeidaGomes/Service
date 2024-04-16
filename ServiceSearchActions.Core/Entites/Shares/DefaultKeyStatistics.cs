using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSearchActions.Core.Entites.Shares
{
    public class DefaultKeyStatistics : BaseEntity
    {
        public int PriceHint { get; set; }
        public long EnterpriseValue { get; set; }
        public double ForwardPE { get; set; }
        public double ProfitMargins { get; set; }
        public long FloatShares { get; set; }
        public long SharesOutstanding { get; set; }
        public double HeldPercentInsiders { get; set; }
        public double HeldPercentInstitutions { get; set; }
        public double Beta { get; set; }
        public long ImpliedSharesOutstanding { get; set; }
        public string Category { get; set; }
        public double BookValue { get; set; }
        public double PriceToBook { get; set; }
        public string FundFamily { get; set; }
        public string LegalType { get; set; }
        public DateTime LastFiscalYearEnd { get; set; }
        public DateTime NextFiscalYearEnd { get; set; }
        public DateTime MostRecentQuarter { get; set; }
        public double EarningsQuarterlyGrowth { get; set; }
        public long NetIncomeToCommon { get; set; }
        public double TrailingEps { get; set; }
        public double ForwardEps { get; set; }
        public double PegRatio { get; set; }
        public string LastSplitFactor { get; set; }
        public int LastSplitDate { get; set; }
        public double EnterpriseToRevenue { get; set; }
        public double EnterpriseToEbitda { get; set; }
        public double WeekChange { get; set; }
        public double SandP52WeekChange { get; set; }
        public double LastDividendValue { get; set; }
        public DateTime LastDividendDate { get; set; }
    }
}
