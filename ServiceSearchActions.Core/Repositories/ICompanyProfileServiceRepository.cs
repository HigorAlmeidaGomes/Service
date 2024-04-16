using ServiceSearchActions.Core.Entites.Shares;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceSearchActions.Core.Repositories
{
    public interface ICompanyProfileServiceRepository
    {
        Task<List<CompanyProfile>> GetAllAsync();
    }
}
