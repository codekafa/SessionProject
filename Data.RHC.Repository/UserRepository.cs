using Core.Data.Repository.Infrastructure;
using Core.Data.Repository.Infrastructure.ModelRepository;
using Data.RHC.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data.RHC.Repository
{
    public class UserRepository : BaseRepository<user>, IUserRepository
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
