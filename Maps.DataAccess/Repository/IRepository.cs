using Maps.DataAccess.Base;
using Maps.Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maps.DataAccess.Repository
{
    /// <summary>
    /// Interface that holds the CRUD contracts
    /// </summary>
    /// <typeparam name="T">Clase Modelo en la cual se realizarán las operaciones CRUD</typeparam>
    /// <typeparam name="TId">Tipo de datos del identificador de la clase</typeparam>
    public interface IRepository<T, Tid> : IRepositoryWithTypedId<T, Tid> where T : IEntityWithTypedId<Tid>
    {
    }
}
