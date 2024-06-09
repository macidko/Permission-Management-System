using Business.Features.Users.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Users.Queries.GetList;

public class GetListQuery : IRequest<ListUserResponse>
{
    public int Page { get; set; }
    public int PageSize { get; set; }

    public class GetListQueryHandler : IRequestHandler<GetListQuery, ListUserResponse>
    {
        public Task<ListUserResponse> Handle(GetListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
