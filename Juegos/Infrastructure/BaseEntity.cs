namespace Juegos.Infrastructure
{
    public class BaseEntity
    {
        public string UpdatedBy { get; private set; }

        public DateTimeOffset UpdatedAt { get; private set; }
    }
}
