using System;
using System.Collections.Generic;
using System.Text;

namespace Maps.Models.Generics
{
    /// <summary>
    /// Base interface for all the entities
    /// </summary>
    /// <typeparam name="Tid"></typeparam>
    public interface IEntityWithTypedId<Tid>
    {
        Tid Id { get; }
    }
}
