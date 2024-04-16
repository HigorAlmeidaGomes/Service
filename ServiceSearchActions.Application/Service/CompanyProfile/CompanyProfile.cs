using ServiceSearchActions.Application.Interface.CompanyProfile;
using ServiceSearchActions.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceSearchActions.Application.Service.CompanyProfile
{
    public class CompanyProfile : ICompanyProfile
    {
        public Task<List<CompanyProfileViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
