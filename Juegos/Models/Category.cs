using Juegos.Infrastructure;

namespace Juegos.Models
{
    public class Category : BaseEntity, IAggregateRoot
    {
        public Category()
        {
            _details = new List<CategoryDetail>();
        }

        public Category(string name) : this()
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        private List<CategoryDetail> _details;

        public IEnumerable<CategoryDetail> Details => _details.AsReadOnly();

    }
}
