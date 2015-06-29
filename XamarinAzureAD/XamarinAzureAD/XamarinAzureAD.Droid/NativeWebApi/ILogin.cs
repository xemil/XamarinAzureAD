// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using XamarinAzureAD.Droid.Models;

namespace XamarinAzureAD.Droid
{
    public partial interface ILogin
    {
        /// <param name='refreshToken'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<AuthenticationResult>> GetByTokenWithOperationResponseAsync(string refreshToken, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='username'>
        /// Required.
        /// </param>
        /// <param name='password'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<AuthenticationResult>> GetByUsernamePasswordWithOperationResponseAsync(string username, string password, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
