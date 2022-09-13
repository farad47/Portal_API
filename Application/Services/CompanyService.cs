using Application.Dto.CompanyDto;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _repository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public IEnumerable<CompanyDto> GetAllCompanies()
        {
            var companies = _repository.GetAllCompanies();
            return _mapper.Map<IEnumerable<CompanyDto>>(companies);
        }
        public CompanyDto AddCompany(AddCompanyDto newCompany)
        {
            var company = _mapper.Map<Company>(newCompany);
            _repository.Add(company);
            return _mapper.Map<CompanyDto>(company);
        }
        public void DeleteCompany(int id)
        {
            _repository.Delete(id);
        }

    }
}
