using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Users.Dtos;

public class ListUserResponse
{
    public int Id { get; set; }
    public string Username { get; set; }
    public int OperationClaimId { get; set; }
}
