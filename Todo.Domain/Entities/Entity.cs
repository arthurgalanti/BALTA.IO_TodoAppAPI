using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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