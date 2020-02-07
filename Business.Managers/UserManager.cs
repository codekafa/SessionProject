using Core.Data.Manager.Infrastructure;
using Core.Data.Repository.Infrastructure.ModelRepository;
using Model.RHC.Api.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Managers
{
    public class UserManager : IUserManager
    {
        IUserRepository _userRepo;
        public UserManager(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }
        public List<UserListModel> GetUsers()
        {
           return _userRepo.All().Select(x => new UserListModel { Email = x.email, UserID = x.id }).ToList();
        }
    }
}
