using Core.Data.Manager.Infrastructure;
using Data.RHC.Repository;
using Microsoft.AspNetCore.Mvc;
using Model.RHC.Api.User;
using Session.Model.Infrastructure;
using System.Collections.Generic;

namespace Session.RHC.Api.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserManager _userM;
        public UserController(IUserManager userM)
        {
            _userM = userM;
        }
        public BaseResultModel<List<UserListModel>> GetUsers()
        {
            return _userM.GetUsers();
        }

    }
}