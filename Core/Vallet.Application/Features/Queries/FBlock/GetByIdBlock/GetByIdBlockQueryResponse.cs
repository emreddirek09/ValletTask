 
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Queries.FBlock.GetByIdBlock
{
    public class GetByIdBlockQueryResponse
    {
        public string? BlockName { get; set; }
        public int BlockNumberOfFloors { get; set; }
        public Guid SiteId { get; set; }
        public ICollection<Daire>? Daires { get; set; }
    }
}
