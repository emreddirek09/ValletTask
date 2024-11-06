using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Queries.FApart.GetByIdApart
{
    public class GetByIdApartQueryResponse
    {
        public string Id { get; set; }
        public int DaireFloorNumber { get; set; }
        public int DaireApartmentNumber { get; set; }
        public Guid? UsersId { get; set; }
        public User? Users { get; set; }
        public Guid? BlockId { get; set; }
        public Blok? Block { get; set; }
        public ICollection<DaireBorc>? DaireBorcs { get; set; }
    }
}
