using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies();
        Company Add(Company company);
        void Delete(int id);
    }
}
