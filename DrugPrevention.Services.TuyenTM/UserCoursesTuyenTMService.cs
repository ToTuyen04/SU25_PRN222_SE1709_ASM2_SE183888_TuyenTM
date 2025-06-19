using DrugPrevention.Repositories.TuyenTM;
using DrugPrevention.Repositories.TuyenTM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugPrevention.Services.TuyenTM
{
    public class UserCoursesTuyenTMService :
        IUserCoursesTuyenTMService
    {
        //private readonly UserCoursesTuyenTMRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public UserCoursesTuyenTMService() => _unitOfWork = new UnitOfWork();

        public async Task<List<UserCoursesTuyenTM>> GetAllAsync()
        {
            return await _unitOfWork.UserCoursesTuyenTMRepository.GetAllAsync();
        }
        public async Task<bool> DeleteAsync(int code)
        {
            var userCourse = await _unitOfWork.UserCoursesTuyenTMRepository.GetByIdAsync(code);
            return await _unitOfWork.UserCoursesTuyenTMRepository.RemoveAsync(userCourse);
        }
    }
}
