using Microsoft.EntityFrameworkCore;
using ServiceSearchActions.Core.Entites.Shares;
using ServiceSearchActions.Core.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceSearchActions.Infrastructure.Persistence.Repositories
{
    public class CompanyProfileServiceRepository : ICompanyProfileServiceRepository
    {
        private readonly ServiceSearchActionsDbContext _dbContext;

  
        public CompanyProfileServiceRepository(ServiceSearchActionsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CompanyProfile>> GetAllAsync()
        {
           return await _dbContext.CompanyProfile.ToListAsync();
        }
    }
}
