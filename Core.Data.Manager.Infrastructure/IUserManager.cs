using Model.RHC.Api.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Manager.Infrastructure
{
    public interface IUserManager
    {

        List<UserListModel> GetUsers();

    }
}
