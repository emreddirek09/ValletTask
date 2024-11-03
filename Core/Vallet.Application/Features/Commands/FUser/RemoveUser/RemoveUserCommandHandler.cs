﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Repositories;

namespace Vallet.Application.Features.Commands.FUser.RemoveUser
{
    public class RemoveUserCommandHandler : IRequestHandler<RemoveUserCommandRequest, RemoveUserCommandResponse>
    { 
        readonly IUserWriteRepository _userWriteRepository;

        public RemoveUserCommandHandler(IUserWriteRepository userWriteRepository)
        {
            _userWriteRepository = userWriteRepository;
        }

        public async Task<RemoveUserCommandResponse> Handle(RemoveUserCommandRequest request, CancellationToken cancellationToken)
        {
            await _userWriteRepository.DeleteAsync(request.Id);
            await _userWriteRepository.SaveAsync();
            return new RemoveUserCommandResponse();
        }

    }
}