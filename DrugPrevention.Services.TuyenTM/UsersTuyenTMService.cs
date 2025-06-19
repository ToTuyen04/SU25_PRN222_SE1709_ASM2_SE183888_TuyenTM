using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugPrevention.Repositories.TuyenTM;
using DrugPrevention.Repositories.TuyenTM.Models;

namespace DrugPrevention.Services.TuyenTM
{
    public class UsersTuyenTMService : IUsersTuyenTMService
    {
        //private readonly UsersTuyenTmRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public UsersTuyenTMService() => _unitOfWork = new UnitOfWork();

        public async Task<List<UsersTuyenTM>> GetAllAsync()
        {
            return await _unitOfWork.UsersTuyenTmRepository.GetAllAsync();
        }
        public async Task<UsersTuyenTM> GetByIdAsync(int code)
        {
            return await _unitOfWork.UsersTuyenTmRepository.GetByIdAsync(code);
        }
        public async Task<List<UsersTuyenTM>> SearchAsync(int code, string email, string name)
        {
            return await _unitOfWork.UsersTuyenTmRepository.SearchAsync(code, email, name);
        }
        public async Task<int> CreateAsync(UsersTuyenTM entity)
        {
            return await _unitOfWork.UsersTuyenTmRepository.CreateAsync(entity);
        }
        public async Task<int> UpdateAsync(UsersTuyenTM entity)
        {
            return await _unitOfWork.UsersTuyenTmRepository.UpdateAsync(entity);
        }
        public async Task<bool> DeleteAsync(int code)
        {
            var user = await _unitOfWork.UsersTuyenTmRepository.GetByIdAsync(code);
            if(user != null)
            {
                return await _unitOfWork.UsersTuyenTmRepository.RemoveCustomize(user);
            }
            return false;
        }
    }
}
