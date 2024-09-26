// <auto-generated>

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// A token constructed from an HttpSigningConfiguration
    /// </summary>
    public class HttpSignatureToken : TokenBase
    {
        private HttpSigningConfiguration _configuration;

        /// <summary>
        /// Constructs an HttpSignatureToken object.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="timeout"></param>
        public HttpSignatureToken(HttpSigningConfiguration configuration, TimeSpan? timeout = null) : base(timeout)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Places the token in the header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken"></param>
        public void UseInHeader(global::System.Net.Http.HttpRequestMessage request, string requestBody, CancellationToken cancellationToken = default)
        {
            var signedHeaders = _configuration.GetHttpSignedHeader(request, requestBody, cancellationToken);

            foreach (var signedHeader in signedHeaders)
                request.Headers.Add(signedHeader.Key, signedHeader.Value);
        }
    }
}