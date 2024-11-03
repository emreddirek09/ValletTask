﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Repositories;

namespace Vallet.Application.Features.Commands.FSite.RemoveSite
{
    public class RemoveSiteCommandHandler : IRequestHandler<RemoveSiteCommandRequest, RemoveSiteCommandResponse>
    {
        readonly ISiteWriteRepository _writeRepository;

        public RemoveSiteCommandHandler(ISiteWriteRepository writeRepository)
        {
            _writeRepository = writeRepository;
        }

        public async Task<RemoveSiteCommandResponse> Handle(RemoveSiteCommandRequest request, CancellationToken cancellationToken)
        {
            await _writeRepository.DeleteAsync(request.Id);
            await _writeRepository.SaveAsync();
            return new RemoveSiteCommandResponse();
        }
    }
}