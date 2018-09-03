using Microsoft.EntityFrameworkCore.Storage;
using Maps.Models.Generics;
using System.Linq;
using System.Threading.Tasks;

namespace Maps.DataAccess.Base
{
    /// <summary>
    /// Interface with the CRUD contracts
    /// </summary>
    /// <typeparam name="T">Model class where the CRUD operations will be executed</typeparam>
    /// <typeparam name="TId">Class Identificator type</typeparam>
    public interface IRepositoryWithTypedId<T, in TId> where T : IEntityWithTypedId<TId>
    {
        /// <summary>
        /// Allows the Query actions
        /// </summary>
        /// <returns></returns>
        IQueryable<T> Query();

        /// <summary>
        /// Adds an element
        /// </summary>
        /// <param name="entity">Object to add</param>
        void Add(T entity);

        /// <summary>
        /// Detachs an element
        /// </summary>
        /// <param name="entity"></param>
        void Detatch(T entity);

        /// <summary>
        /// Adss an element asynchronously
        /// </summary>
        /// <param name="entity">Object to add</param>
        Task AddAsync(T entity);

        /// <summary>
        /// Updates an especific element
        /// </summary>
        /// <param name="entity">Object to update</param>
        void Update(T entity);

        /// <summary>
        /// Begins the transaction
        /// </summary>
        /// <returns></returns>
        IDbContextTransaction BeginTransaction();

        /// <summary>
        /// Save model changes
        /// </summary>
        /// <returns></returns>
        int SaveChange();

        /// <summary>
        /// Save model changes asynchronously
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangeAsync();

        /// <summary>
        /// Deletes an element
        /// </summary>
        /// <param name="entity">Object to remove from the context</param>
        void Remove(T entity);
    }
}