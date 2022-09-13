using Application.Dto.CompanyDto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICompanyService
    {
        IEnumerable<CompanyDto> GetAllCompanies();
        CompanyDto AddCompany(AddCompanyDto newCompany);
        void DeleteCompany(int id);
    }
}
