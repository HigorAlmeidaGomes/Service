using ServiceSearchActions.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSearchActions.Application.Interface.CompanyProfile
{
    public interface ICompanyProfile
    {
        Task<List<CompanyProfileViewModel>> GetAll();
    }
}
