using DrugPrevention.Repositories.TuyenTM;
using DrugPrevention.Repositories.TuyenTM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugPrevention.Services.TuyenTM
{
    public class OrganizationsTuyenTMService : IOrganizationsTuyenTMService
    {
        //private readonly OrganizationsTuyenTMRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public OrganizationsTuyenTMService() => _unitOfWork = new UnitOfWork();

        public async Task<List<OrganizationsTuyenTM>> GetAllAsync()
        {
            return await _unitOfWork.OrganizationsTuyenTMRepository.GetAllAsync();
        }
        public async Task<OrganizationsTuyenTM> GetByIdAsync(int id)
        {
            return await _unitOfWork.OrganizationsTuyenTMRepository.GetByIdAsync(id);
        }
        public async Task<List<OrganizationsTuyenTM>> SearchAsync(int id, string name, string type)
        {
            return await _unitOfWork.OrganizationsTuyenTMRepository.SearchAsync(id, name, type);
        }
        public async Task<int> AddAsync(OrganizationsTuyenTM organization)
        {
            return await _unitOfWork.OrganizationsTuyenTMRepository.CreateAsync(organization);
        }
        public async Task<int> UpdateAsync(OrganizationsTuyenTM organization)
        {
            return await _unitOfWork.OrganizationsTuyenTMRepository.UpdateAsync(organization);
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var organization = await _unitOfWork.OrganizationsTuyenTMRepository.GetByIdAsync(id);
            if (organization != null)
            {
                return await _unitOfWork.OrganizationsTuyenTMRepository.RemoveAsync(organization);
            }
            return false;
        }
    }
}
