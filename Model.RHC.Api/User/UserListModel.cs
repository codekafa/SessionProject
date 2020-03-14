using Session.Model.Infrastructure;

namespace Model.RHC.Api.User
{
    public class UserListModel : IModel
    {
        public int UserID { get; set; }

        public string Email { get; set; }

    }
}
