using MediatR; 
using Vallet.Application.Repositories; 

namespace Vallet.Application.Features.Queries.FUser.GetAllUser
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQueryRequest, GetAllUserQueryResponse>
    {
        readonly IUserReadRepository _userReadRepository;

        public GetAllUserQueryHandler(IUserReadRepository userReadRepository)
        {
            _userReadRepository = userReadRepository;
        }

        public async Task<GetAllUserQueryResponse> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
            var user =  _userReadRepository.GetAll(false);

            return new()
            {
                Data = user
            };
        }
    }
}
