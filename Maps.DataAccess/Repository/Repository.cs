using Maps.DataAccess.Base;
using Maps.Models.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maps.DataAccess.Repository
{
    /// <summary>
    /// Repository that implements the CRUD operations
    /// </summary>
    /// <typeparam name="T">Model class where the CRUD operations will be executed</typeparam>
    /// <typeparam name="Tid">Class Identificator type</typeparam>
    public class Repository<T, Tid> : RepositoryWithTypedId<T, Tid>, IRepository<T, Tid>
      where T : class, IEntityWithTypedId<Tid>
    {
        public Repository(MapsDbContext context) : base(context)
        {

        }
    }
}
