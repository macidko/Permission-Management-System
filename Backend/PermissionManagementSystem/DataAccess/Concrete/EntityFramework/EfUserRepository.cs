using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfUserRepository : EfRepositoryBase<User, BaseDbContext>, IUserRepository
{
    public EfUserRepository(BaseDbContext context) : base(context)
    {
    }
}
