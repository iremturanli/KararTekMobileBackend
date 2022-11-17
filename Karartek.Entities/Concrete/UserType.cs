using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class UserType : BaseEntity
    {

        public int TypeId { get; set; }
        public string TypeName { get; set; } = null!;
        public IEnumerable<User>? Users { get; set; } = null!;
    }
}

