// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using MobileApi.RestServices.SipEntities;

namespace MobileApi.RestServices.SipEntities
{
    public partial interface ISipEntitiesClient : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri
        {
            get; set; 
        }
        
        IUsers Users
        {
            get; 
        }
        
        IValues Values
        {
            get; 
        }
    }
}