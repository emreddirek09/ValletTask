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
                id = user.Id.ToString(),
                phoneNumber = user.PhoneNumber,
                email = user.Email,
                fullName = user.FullName,
                role = user.Role,
                creteTime = Convert.ToDateTime(user.CreatedTime)
                
            };
        }
    }
}
