using Entities.Concrete;

namespace Entities
{
    public class UserOperationClaim : Core.Entities.UserOperationClaim
    {
        public virtual OperationClaim OperationClaim { get; set; }
        public virtual User User { get; set; }

    }
}