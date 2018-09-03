using Maps.Services.RequestProvider;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using System.Text;

namespace Maps.Services
{
    public class BaseService
    {
        /// <summary>
        /// HTTP Requests provider
        /// </summary>
        protected readonly IRequestProvider _requestProvider;

        /// <summary>
        /// Allows to check the internet connection
        /// </summary>
        /// <returns></returns>
        protected bool IsConnected => Connectivity.NetworkAccess != NetworkAccess.None;

        /// <summary>
        /// Service Constructor
        /// </summary>
        /// <param name="requestProvider">HTTP Requests provider</param>
        public BaseService(IRequestProvider requestProvider)
        {
            _requestProvider = requestProvider;
        }
    }
}
