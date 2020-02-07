using Core.Data.Manager.Infrastructure;
using Data.RHC.Repository;
using Microsoft.AspNetCore.Mvc;
using Model.RHC.Api.User;
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
        public List<UserListModel> GetUsers()
        {
            return _userM.GetUsers();
        }

    }
}