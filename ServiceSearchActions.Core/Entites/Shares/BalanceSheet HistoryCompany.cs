using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSearchActions.Core.Entites.Shares
{
    public class BalanceSheetHistoryCompany : BaseEntity
    {
        public List<BalanceSheetStatements> BalanceSheetHistories { get; set; }
    }
}
