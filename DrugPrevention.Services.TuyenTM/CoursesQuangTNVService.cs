using DrugPrevention.Repositories.TuyenTM;
using DrugPrevention.Repositories.TuyenTM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugPrevention.Services.TuyenTM
{
    public class CoursesQuangTNVService : ICoursesQuangTNVService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoursesQuangTNVService() => _unitOfWork = new UnitOfWork();

        public Task<int> CreateAsync(CoursesQuangTNV entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(int code)
        {
            var enity = await _unitOfWork.CoursesQuangTNVRepository.GetByIdAsync(code);
            if(enity != null)
            {
                return await _unitOfWork.CoursesQuangTNVRepository.RemoveAsync(enity);
            }
            return false;
        }

        public async Task<List<CoursesQuangTNV>> GetAllAsync()
        {
            return await _unitOfWork.CoursesQuangTNVRepository.GetAllAsync();
        }

        public async Task<CoursesQuangTNV> GetByIdAsync(int code)
        {
            return await _unitOfWork.CoursesQuangTNVRepository.GetByIdAsync(code);
        }

        public async Task<List<CoursesQuangTNV>> SearchAsync(int duration, string title, string category)
        {
            return await _unitOfWork.CoursesQuangTNVRepository.SearchAsync(duration, title, category);
        }


        public async Task<int> UpdateAsync(CoursesQuangTNV entity)
        {
            return await _unitOfWork.CoursesQuangTNVRepository.UpdateAsync(entity);
        }
    }
}
