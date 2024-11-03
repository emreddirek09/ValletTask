using MediatR;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Queries.FUser.GetByIdUser
{
    public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQueryRequest, GetByIdUserQueryResponse>
    {
        readonly IUserReadRepository _userReadRepository;

        public GetByIdUserQueryHandler(IUserReadRepository userReadRepository)
        {
            _userReadRepository = userReadRepository;
        }

        public async Task<GetByIdUserQueryResponse> Handle(GetByIdUserQueryRequest request, CancellationToken cancellationToken)
        {
            User user = await _userReadRepository.GetByIdAsync(request.Id,false);

            return new()
            {
                Id = user.Id.ToString(),
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                FullName = user.FullName,
                Role = user.Role
            };
        }
    }
}
