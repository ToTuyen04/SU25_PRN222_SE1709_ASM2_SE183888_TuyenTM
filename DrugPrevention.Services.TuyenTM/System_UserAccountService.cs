using DrugPrevention.Repositories.TuyenTM;
using DrugPrevention.Repositories.TuyenTM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugPrevention.Services.TuyenTM
{
    public class System_UserAccountService
    {
        private readonly IUnitOfWork _unitOfWork;

        public System_UserAccountService() => _unitOfWork = new UnitOfWork();

        public async Task<System_UserAccount> GetUserAccount(string username, string password)
        {
            return await _unitOfWork.System_UserAccountRepository.GetUserAccountAsync(username, password);
        }

        public async Task<System_UserAccount> GetUserAccountByUserNameAsync(string username)
        {
            return await _unitOfWork.System_UserAccountRepository.GetUserAccountByUserNameAsync(username);
        }

        public async Task<List<System_UserAccount>> GetAllAsync()
        {
            return await _unitOfWork.System_UserAccountRepository.GetAllAsync();
        }

        public async Task<System_UserAccount> GetByIdAsync(int id)
        {
            return await _unitOfWork.System_UserAccountRepository.GetByIdAsync(id);
        }

        public async Task<int> CreateAsync(System_UserAccount entity)
        {
            return await _unitOfWork.System_UserAccountRepository.CreateAsync(entity);
        }

        public async Task<int> UpdateAsync(System_UserAccount entity)
        {
            return await _unitOfWork.System_UserAccountRepository.UpdateAsync(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var user = await _unitOfWork.System_UserAccountRepository.GetByIdAsync(id);
            if (user != null && user.UserAccountID > 0)
            {
                user.IsActive = false; // Soft delete
                await _unitOfWork.System_UserAccountRepository.UpdateAsync(user);
                return true;
            }
            return false;
        }
    }
}
