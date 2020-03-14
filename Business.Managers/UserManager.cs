using Core.Data.Manager.Infrastructure;
using Core.Data.Repository.Infrastructure.ModelRepository;
using Model.RHC.Api.User;
using Session.Model.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace Business.RHC.Managers
{
    public class UserManager : IUserManager
    {
        IUserRepository _userRepo;
        public UserManager(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public BaseResultModel<SingleUserModel> GetUserByEmail(string email)
        {
            BaseResultModel<SingleUserModel> result = new BaseResultModel<SingleUserModel>();
            result.IsSuccess = true;
            result.Data = _userRepo.Where(x => x.email == email).Select(x => new SingleUserModel { Email = x.email, ENVType = x.envorirement_type, FullName = x.first_name + " " + x.last_name, IsActive = x.is_active, IsApprove = x.is_approve, UserType = x.user_type, UserID = x.id }).FirstOrDefault();
            return result;
        }

        public BaseResultModel<SingleUserModel> GetUserByEmailAndPassword(string email, string password)
        {
            BaseResultModel<SingleUserModel> result = new BaseResultModel<SingleUserModel>();
            result.IsSuccess = true;
            result.Data = _userRepo.Where(x => x.email == email && x.password == password).Select(x => new SingleUserModel { Email = x.email, ENVType = x.envorirement_type, FullName = x.first_name + " " + x.last_name, IsActive = x.is_active, IsApprove = x.is_approve, UserType = x.user_type, UserID = x.id }).FirstOrDefault();
            return result;
        }

        public BaseResultModel<SingleUserModel> GetUserById(int id)
        {
            BaseResultModel<SingleUserModel> result = new BaseResultModel<SingleUserModel>();
            result.IsSuccess = true;
            result.Data = _userRepo.Where(x => x.id == id).Select(x => new SingleUserModel { Email = x.email, ENVType = x.envorirement_type, FullName = x.first_name + " " + x.last_name, IsActive = x.is_active, IsApprove = x.is_approve, UserType = x.user_type, UserID = x.id }).FirstOrDefault();
            return result;
        }

        public BaseResultModel<List<UserListModel>> GetUsers()
        {
            BaseResultModel<List<UserListModel>> result = new BaseResultModel<List<UserListModel>>();
            result.IsSuccess = true;
            result.Data = _userRepo.All().Select(x => new UserListModel { Email = x.email, UserID = x.id }).ToList();
            return result;
        }

        public BaseResultModel<SingleUserModel> RegisterUser(RegisterUserModel registerUser)
        {

            var exist = GetUserByEmail(registerUser.Email);

            BaseResultModel<SingleUserModel> result = new BaseResultModel<SingleUserModel>();


            return result;
        }
    }
}
