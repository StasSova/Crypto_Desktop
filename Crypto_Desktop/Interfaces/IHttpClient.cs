using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Desktop.Interfaces
{
    public interface IHttpClient
    {
        /// <summary>
        ///     Sends an API request async using GET Method
        /// </summary>
        /// <param name="resourceUri"> </param>
        /// <returns>Asyncronous result turns by TApiResouce</returns>
        Task<T> GetAsync<T>(Uri resourceUri);
    }
}
