using Core.DataAccess;
using Entities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;

public class EfUserOperationClaimRepository : EfRepositoryBase<UserOperationClaim, BaseDbContext>, IUserOperationClaimRepository
{
    public EfUserOperationClaimRepository(BaseDbContext context) : base(context)
    {
    }
}
