using Domain.Entities;
using Domain.Entities.Common;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _context;

        public CompanyRepository (ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Company> GetAllCompanies()
        {
            return _context.Company.ToList();
        }
        public Company Add(Company company)
        {
            company.CreatedBy = "Admin";
            _context.Company.Add(company);
            _context.SaveChanges();
            return company;
        }

        public void Delete(int id)
        {
            var company = _context.Company.SingleOrDefault(x => x.CompanyId == id);
            _context.Company.Remove(company);
            _context.SaveChanges();
        }


    }
}
