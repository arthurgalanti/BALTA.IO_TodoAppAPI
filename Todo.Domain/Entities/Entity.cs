namespace Todo.Domain.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        protected Entity(Guid id)
        {
            Id = id;
        }

        public Guid Id {get; private set;}

        public bool Equals(Entity? other)
        {
            return Id == other?.Id;
        }
    }
}