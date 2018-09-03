using System.Threading.Tasks;

namespace Maps.Services.RequestProvider
{
    public interface IRequestProvider
    {
        /// <summary>
        /// Generates a GET request to the URI with the specified token
        /// </summary>
        /// <typeparam name="TResult">Data type expected</typeparam>
        /// <param name="uri">URI</param>
        /// <param name="token">Token</param>
        /// <returns>TResult object</returns>
        Task<TResult> GetAsync<TResult>(string uri, string token = "");

        /// <summary>
        /// Generates a POST request to the URI with the specified token
        /// </summary>
        /// <typeparam name="TResult">Data type expected</typeparam>
        /// <param name="uri">URI</param>
        /// <param name="data">Data</param>
        /// <param name="token">Token</param>
        /// <param name="header">Http headers</param>
        /// <returns>Result</returns>
        Task<TResult> PostAsync<TResult>(string uri, TResult data, string token = "", string header = "");

        /// <summary>
        /// Generates a POST request to the URI with the specified token
        /// </summary>
        /// <typeparam name="TResult">Data type expected</typeparam>
        /// <typeparam name="TEntry">Data type sended</typeparam>
        /// <param name="uri">URI</param>
        /// <param name="data">Data</param>
        /// <param name="token">Token</param>
        /// <param name="header">http headers</param>
        /// <returns>Result</returns>
        Task<TResult> PostAsync<TResult, TEntry>(string uri, TEntry data, string token = "", string header = "");

        /// <summary>
        /// Generates a POST request to the URI with the specified token
        /// </summary>
        /// <typeparam name="TResult">Data type expected</typeparam>
        /// <param name="uri">URI</param>
        /// <param name="data">Entry data (x-www-form-urlencoded)</param>
        /// <param name="clientId">Client Id</param>
        /// <param name="clientSecret">Client Secret</param>
        /// <returns></returns>
        Task<TResult> PostAsync<TResult>(string uri, string data, string clientId, string clientSecret);

        /// <summary>
        /// Generates a PUT request to the URI with the specified token
        /// </summary>
        /// <typeparam name="TResult">Data type expected</typeparam>
        /// <param name="uri">URI</param>
        /// <param name="data">Data</param>
        /// <param name="token">Token</param>
        /// <param name="header">http headers</param>
        /// <returns>Result</returns>
        Task<TResult> PutAsync<TResult>(string uri, TResult data, string token = "", string header = "");

        /// <summary>
        /// Generates a DELETE request to the URI with the specified token
        /// </summary>
        /// <typeparam name="TResult">Data type expected</typeparam>
        /// <param name="uri">URI</param>
        /// <param name="token">Token</param>
        Task DeleteAsync(string uri, string token = "");
    }
}
