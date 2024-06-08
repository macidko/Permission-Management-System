using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class UserOperationClaim: Entity
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public int OperationClaimId { get; set; }
    public virtual User User { get; set; }
    public virtual OperationClaim OperationClaim { get; set; }

}
