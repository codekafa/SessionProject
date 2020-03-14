using Model.RHC.Api.User;
using Session.Model.Infrastructure;
using System.Collections.Generic;

namespace Core.Data.Manager.Infrastructure
{
    public interface IUserManager
    {

        BaseResultModel<List<UserListModel>> GetUsers();

        BaseResultModel<SingleUserModel> GetUserById(int id);

        BaseResultModel<SingleUserModel> GetUserByEmail(string email);

        BaseResultModel<SingleUserModel> GetUserByEmailAndPassword(string email, string password);

        BaseResultModel<SingleUserModel> RegisterUser(RegisterUserModel registerUser);
            

    }
}
