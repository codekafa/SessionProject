using Session.Model.Infrastructure;

namespace Model.RHC.Api.User
{
    public class SingleUserModel : IModel
    {
        public int UserID { get; set; }

        public string FullName { get; set; }

        public string CompanyName { get; set; }

        public string Email { get; set; }

        public bool IsActive { get; set; }

        public bool IsApprove { get; set; }

        public int ENVType { get; set; }

        public int UserType { get; set; }
    }
}
