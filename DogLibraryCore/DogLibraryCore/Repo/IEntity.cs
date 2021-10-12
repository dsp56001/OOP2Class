using System;
using System.Collections.Generic;
using System.Text;

namespace DogLibraryCore
{
    public interface IEntity
    {
        int Id { get; }
    }

    public abstract class EntityBase : IEntity
    {
        public int Id { get; protected set; }
    }
}
