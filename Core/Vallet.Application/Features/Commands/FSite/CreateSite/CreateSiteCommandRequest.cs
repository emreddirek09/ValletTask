using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.Features.Commands.FSite.CreateSite
{
    public class CreateSiteCommandRequest : IRequest<CreateSiteCommandResponse>
    {
        public string? SiteName { get; set; }
        public string? SiteAddress { get; set; }
        public bool SiteIsApartment { get; set; }
    }
}
