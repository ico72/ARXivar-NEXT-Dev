/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGlobalSearchV3Api : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search/{searchFilter&#x3D;searchFilter}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>Object</returns>
        Object GlobalSearchV3GetFullIndexSearch (string searchFilter);

        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search/{searchFilter&#x3D;searchFilter}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GlobalSearchV3GetFullIndexSearchWithHttpInfo (string searchFilter);
        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fullindexsearchrequestdto"> (optional)</param>
        /// <returns>Object</returns>
        Object GlobalSearchV3GetFullIndexSearch_0 (FullIndexSearchRequestDto fullindexsearchrequestdto = null);

        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fullindexsearchrequestdto"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GlobalSearchV3GetFullIndexSearch_0WithHttpInfo (FullIndexSearchRequestDto fullindexsearchrequestdto = null);
        /// <summary>
        /// This call returns all elements match the given filter
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>List&lt;GenericItemDTO&gt;</returns>
        List<GenericItemDTO> GlobalSearchV3GlobalSearch (string searchFilter);

        /// <summary>
        /// This call returns all elements match the given filter
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>ApiResponse of List&lt;GenericItemDTO&gt;</returns>
        ApiResponse<List<GenericItemDTO>> GlobalSearchV3GlobalSearchWithHttpInfo (string searchFilter);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search/{searchFilter&#x3D;searchFilter}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GlobalSearchV3GetFullIndexSearchAsync (string searchFilter);

        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search/{searchFilter&#x3D;searchFilter}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GlobalSearchV3GetFullIndexSearchAsyncWithHttpInfo (string searchFilter);
        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fullindexsearchrequestdto"> (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GlobalSearchV3GetFullIndexSearch_0Async (FullIndexSearchRequestDto fullindexsearchrequestdto = null);

        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fullindexsearchrequestdto"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GlobalSearchV3GetFullIndexSearch_0AsyncWithHttpInfo (FullIndexSearchRequestDto fullindexsearchrequestdto = null);
        /// <summary>
        /// This call returns all elements match the given filter
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>Task of List&lt;GenericItemDTO&gt;</returns>
        System.Threading.Tasks.Task<List<GenericItemDTO>> GlobalSearchV3GlobalSearchAsync (string searchFilter);

        /// <summary>
        /// This call returns all elements match the given filter
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>Task of ApiResponse (List&lt;GenericItemDTO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<GenericItemDTO>>> GlobalSearchV3GlobalSearchAsyncWithHttpInfo (string searchFilter);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GlobalSearchV3Api : IGlobalSearchV3Api
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSearchV3Api"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobalSearchV3Api(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSearchV3Api"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobalSearchV3Api(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search/{searchFilter&#x3D;searchFilter} 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>Object</returns>
        public Object GlobalSearchV3GetFullIndexSearch (string searchFilter)
        {
             ApiResponse<Object> localVarResponse = GlobalSearchV3GetFullIndexSearchWithHttpInfo(searchFilter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search/{searchFilter&#x3D;searchFilter} 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GlobalSearchV3GetFullIndexSearchWithHttpInfo (string searchFilter)
        {
            // verify the required parameter 'searchFilter' is set
            if (searchFilter == null)
                throw new ApiException(400, "Missing required parameter 'searchFilter' when calling GlobalSearchV3Api->GlobalSearchV3GetFullIndexSearch");

            var localVarPath = "/api/v3/GlobalSearches/search/{searchFilter}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchFilter != null) localVarPathParams.Add("searchFilter", this.Configuration.ApiClient.ParameterToString(searchFilter)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GlobalSearchV3GetFullIndexSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search/{searchFilter&#x3D;searchFilter} 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GlobalSearchV3GetFullIndexSearchAsync (string searchFilter)
        {
             ApiResponse<Object> localVarResponse = await GlobalSearchV3GetFullIndexSearchAsyncWithHttpInfo(searchFilter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search/{searchFilter&#x3D;searchFilter} 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GlobalSearchV3GetFullIndexSearchAsyncWithHttpInfo (string searchFilter)
        {
            // verify the required parameter 'searchFilter' is set
            if (searchFilter == null)
                throw new ApiException(400, "Missing required parameter 'searchFilter' when calling GlobalSearchV3Api->GlobalSearchV3GetFullIndexSearch");

            var localVarPath = "/api/v3/GlobalSearches/search/{searchFilter}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchFilter != null) localVarPathParams.Add("searchFilter", this.Configuration.ApiClient.ParameterToString(searchFilter)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GlobalSearchV3GetFullIndexSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fullindexsearchrequestdto"> (optional)</param>
        /// <returns>Object</returns>
        public Object GlobalSearchV3GetFullIndexSearch_0 (FullIndexSearchRequestDto fullindexsearchrequestdto = null)
        {
             ApiResponse<Object> localVarResponse = GlobalSearchV3GetFullIndexSearch_0WithHttpInfo(fullindexsearchrequestdto);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fullindexsearchrequestdto"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GlobalSearchV3GetFullIndexSearch_0WithHttpInfo (FullIndexSearchRequestDto fullindexsearchrequestdto = null)
        {

            var localVarPath = "/api/v3/GlobalSearches/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fullindexsearchrequestdto != null && fullindexsearchrequestdto.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(fullindexsearchrequestdto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fullindexsearchrequestdto; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GlobalSearchV3GetFullIndexSearch_0", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fullindexsearchrequestdto"> (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GlobalSearchV3GetFullIndexSearch_0Async (FullIndexSearchRequestDto fullindexsearchrequestdto = null)
        {
             ApiResponse<Object> localVarResponse = await GlobalSearchV3GetFullIndexSearch_0AsyncWithHttpInfo(fullindexsearchrequestdto);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fullindexsearchrequestdto"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GlobalSearchV3GetFullIndexSearch_0AsyncWithHttpInfo (FullIndexSearchRequestDto fullindexsearchrequestdto = null)
        {

            var localVarPath = "/api/v3/GlobalSearches/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fullindexsearchrequestdto != null && fullindexsearchrequestdto.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(fullindexsearchrequestdto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fullindexsearchrequestdto; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GlobalSearchV3GetFullIndexSearch_0", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// This call returns all elements match the given filter 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>List&lt;GenericItemDTO&gt;</returns>
        public List<GenericItemDTO> GlobalSearchV3GlobalSearch (string searchFilter)
        {
             ApiResponse<List<GenericItemDTO>> localVarResponse = GlobalSearchV3GlobalSearchWithHttpInfo(searchFilter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns all elements match the given filter 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>ApiResponse of List&lt;GenericItemDTO&gt;</returns>
        public ApiResponse< List<GenericItemDTO> > GlobalSearchV3GlobalSearchWithHttpInfo (string searchFilter)
        {
            // verify the required parameter 'searchFilter' is set
            if (searchFilter == null)
                throw new ApiException(400, "Missing required parameter 'searchFilter' when calling GlobalSearchV3Api->GlobalSearchV3GlobalSearch");

            var localVarPath = "/api/v3/GlobalSearches/{searchFilter}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchFilter != null) localVarPathParams.Add("searchFilter", this.Configuration.ApiClient.ParameterToString(searchFilter)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GlobalSearchV3GlobalSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<GenericItemDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<GenericItemDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<GenericItemDTO>)));
        }

        /// <summary>
        /// This call returns all elements match the given filter 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>Task of List&lt;GenericItemDTO&gt;</returns>
        public async System.Threading.Tasks.Task<List<GenericItemDTO>> GlobalSearchV3GlobalSearchAsync (string searchFilter)
        {
             ApiResponse<List<GenericItemDTO>> localVarResponse = await GlobalSearchV3GlobalSearchAsyncWithHttpInfo(searchFilter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns all elements match the given filter 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter">Filter to be applied to the search</param>
        /// <returns>Task of ApiResponse (List&lt;GenericItemDTO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<GenericItemDTO>>> GlobalSearchV3GlobalSearchAsyncWithHttpInfo (string searchFilter)
        {
            // verify the required parameter 'searchFilter' is set
            if (searchFilter == null)
                throw new ApiException(400, "Missing required parameter 'searchFilter' when calling GlobalSearchV3Api->GlobalSearchV3GlobalSearch");

            var localVarPath = "/api/v3/GlobalSearches/{searchFilter}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchFilter != null) localVarPathParams.Add("searchFilter", this.Configuration.ApiClient.ParameterToString(searchFilter)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GlobalSearchV3GlobalSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<GenericItemDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<GenericItemDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<GenericItemDTO>)));
        }

    }
}