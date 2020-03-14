using Session.Model.Infrastructure;

namespace Model.RHC.Api.User
{
    public class RegisterUserModel : IModel
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string PasswordAgain { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

    }
}
