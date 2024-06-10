using Core.DataAccess;
using Entities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework;

public class EfOperationClaimRepository: EfRepositoryBase<OperationClaim, BaseDbContext>, IOperationClaimRepository
{
    public EfOperationClaimRepository(BaseDbContext context): base(context)
    {

    }
}
