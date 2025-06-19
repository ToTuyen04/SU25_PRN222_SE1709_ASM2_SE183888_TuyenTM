using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugPrevention.Services.TuyenTM
{
    public interface IServiceProviders
    {
        // Define methods that will be implemented by the service providers
        System_UserAccountService System_UserAccountService { get; }

        ICommunityProgramToanNSService CommunityProgramToanNSService { get; }
        ICoursesQuangTNVService CoursesQuangTNVService { get; }
        IOrganizationProgramsTuyenTMService OrganizationProgramsTuyenTMService { get; }
        IOrganizationsTuyenTMService OrganizationsTuyenTMService { get; }

        IUserCoursesTuyenTMService UserCoursesTuyenTMService { get; }
        IUsersTuyenTMService UsersTuyenTMService { get; }
    }
    public class ServiceProviders : IServiceProviders
    {
        private ICommunityProgramToanNSService? _communityProgramToanNSService;
        private ICoursesQuangTNVService? _coursesQuangTNVService;
        private IOrganizationProgramsTuyenTMService? _organizationProgramsTuyenTMService;
        private IOrganizationsTuyenTMService? _organizationsTuyenTMService;
        private System_UserAccountService? _system_UserAccountService;
        private IUserCoursesTuyenTMService? _userCoursesTuyenTMService;
        private IUsersTuyenTMService? _usersTuyenTMService;

        public ServiceProviders() { }
        public System_UserAccountService System_UserAccountService
        {
            get
            {
                return _system_UserAccountService ??= new System_UserAccountService();
            }
        }

        public ICommunityProgramToanNSService CommunityProgramToanNSService
        {
            get
            {
                return _communityProgramToanNSService ??= new CommunityProgramToanNSService();
            }
        }

        public ICoursesQuangTNVService CoursesQuangTNVService
        {
            get
            {
                return _coursesQuangTNVService ??= new CoursesQuangTNVService();
            }
        }

        public IOrganizationProgramsTuyenTMService OrganizationProgramsTuyenTMService {
            get
            {
                return _organizationProgramsTuyenTMService ??= new OrganizationProgramsTuyenTMService();
            }
        }

        public IOrganizationsTuyenTMService OrganizationsTuyenTMService
        {
            get
            {
                return _organizationsTuyenTMService ??= new OrganizationsTuyenTMService();
            }
        }

        public IUserCoursesTuyenTMService UserCoursesTuyenTMService
        {
            get
            {
                return _userCoursesTuyenTMService ??= new UserCoursesTuyenTMService();
            }
        }

        public IUsersTuyenTMService UsersTuyenTMService
        {
            get
            {
                return _usersTuyenTMService ??= new UsersTuyenTMService();
            }
        }
    }
}
