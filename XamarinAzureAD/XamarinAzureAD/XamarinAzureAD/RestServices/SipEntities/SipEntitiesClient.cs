// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using Microsoft.Rest;
using MobileApi.RestServices.SipEntities;

namespace MobileApi.RestServices.SipEntities
{
    public partial class SipEntitiesClient : ServiceClient<SipEntitiesClient>, ISipEntitiesClient
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
            set { this._baseUri = value; }
        }
        
        private IUsers _users;
        
        public virtual IUsers Users
        {
            get { return this._users; }
        }
        
        private IValues _values;
        
        public virtual IValues Values
        {
            get { return this._values; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SipEntitiesClient class.
        /// </summary>
        public SipEntitiesClient()
            : base()
        {
            this._users = new Users(this);
            this._values = new Values(this);
            this._baseUri = new Uri("https://microsoft-apiapp745d3ca9013d4894bebef4e0a6f85f8e.azurewebsites.net:443");
        }
        
        /// <summary>
        /// Initializes a new instance of the SipEntitiesClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public SipEntitiesClient(params DelegatingHandler[] handlers)
            : base(handlers)
        {
            this._users = new Users(this);
            this._values = new Values(this);
            this._baseUri = new Uri("https://microsoft-apiapp745d3ca9013d4894bebef4e0a6f85f8e.azurewebsites.net:443");
        }
        
        /// <summary>
        /// Initializes a new instance of the SipEntitiesClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public SipEntitiesClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
            : base(rootHandler, handlers)
        {
            this._users = new Users(this);
            this._values = new Values(this);
            this._baseUri = new Uri("https://microsoft-apiapp745d3ca9013d4894bebef4e0a6f85f8e.azurewebsites.net:443");
        }
        
        /// <summary>
        /// Initializes a new instance of the SipEntitiesClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public SipEntitiesClient(Uri baseUri, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._baseUri = baseUri;
        }
    }
}