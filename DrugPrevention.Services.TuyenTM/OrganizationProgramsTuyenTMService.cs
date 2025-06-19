using DrugPrevention.Repositories.TuyenTM;
using DrugPrevention.Repositories.TuyenTM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugPrevention.Services.TuyenTM
{
    public class OrganizationProgramsTuyenTMService : IOrganizationProgramsTuyenTMService
    {
        //private readonly OrganizationProgramsTuyenTMRepository _repository;
        private readonly UnitOfWork _unitOfWork;
        public OrganizationProgramsTuyenTMService() => _unitOfWork = new UnitOfWork();

        public async Task<List<OrganizationProgramsTuyenTM>> GetAllAsync()
        {
            return await _unitOfWork.OrganizationProgramsTuyenTMRepository.GetAllAsync();
        }

        public async Task<OrganizationProgramsTuyenTM> GetByIdAsync(int id)
        {
            return await _unitOfWork.OrganizationProgramsTuyenTMRepository.GetByIdAsync(id);
        }

        public async Task<List<OrganizationProgramsTuyenTM>> SearchAsync(int id, string name, string type)
        {
            return await _unitOfWork.OrganizationProgramsTuyenTMRepository.SearchAsync(id, name, type);
        }

        public async Task<int> AddAsync(OrganizationProgramsTuyenTM program)
        {
            return await _unitOfWork.OrganizationProgramsTuyenTMRepository.CreateAsync(program);
        }

        public async Task<int> UpdateAsync(OrganizationProgramsTuyenTM program)
        {
            //program.JoinedDate = DateTime.
            program.LastUpdated = DateTime.Now;
            return await _unitOfWork.OrganizationProgramsTuyenTMRepository.UpdateAsync(program);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var program = await _unitOfWork.OrganizationProgramsTuyenTMRepository.GetByIdAsync(id);
            if (program != null)
            {
                return await _unitOfWork.OrganizationProgramsTuyenTMRepository.RemoveAsync(program);
            }
            return false;
        }
    }
}
