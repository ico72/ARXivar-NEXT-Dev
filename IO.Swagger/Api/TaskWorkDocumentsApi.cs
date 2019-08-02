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

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaskWorkDocumentsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call returns the bufferId for document preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processdocId"></param>
        /// <param name="taskworkId"></param>
        /// <returns>string</returns>
        string TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferId (int? processdocId, int? taskworkId);

        /// <summary>
        /// This call returns the bufferId for document preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processdocId"></param>
        /// <param name="taskworkId"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferIdWithHttpInfo (int? processdocId, int? taskworkId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call returns the bufferId for document preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processdocId"></param>
        /// <param name="taskworkId"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferIdAsync (int? processdocId, int? taskworkId);

        /// <summary>
        /// This call returns the bufferId for document preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processdocId"></param>
        /// <param name="taskworkId"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferIdAsyncWithHttpInfo (int? processdocId, int? taskworkId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TaskWorkDocumentsApi : ITaskWorkDocumentsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWorkDocumentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TaskWorkDocumentsApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWorkDocumentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TaskWorkDocumentsApi(IO.Swagger.Client.Configuration configuration = null)
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
        /// This call returns the bufferId for document preview 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processdocId"></param>
        /// <param name="taskworkId"></param>
        /// <returns>string</returns>
        public string TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferId (int? processdocId, int? taskworkId)
        {
             ApiResponse<string> localVarResponse = TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferIdWithHttpInfo(processdocId, taskworkId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns the bufferId for document preview 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processdocId"></param>
        /// <param name="taskworkId"></param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferIdWithHttpInfo (int? processdocId, int? taskworkId)
        {
            // verify the required parameter 'processdocId' is set
            if (processdocId == null)
                throw new ApiException(400, "Missing required parameter 'processdocId' when calling TaskWorkDocumentsApi->TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferId");
            // verify the required parameter 'taskworkId' is set
            if (taskworkId == null)
                throw new ApiException(400, "Missing required parameter 'taskworkId' when calling TaskWorkDocumentsApi->TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferId");

            var localVarPath = "/api/TaskWorkDocuments/documentPreviewBufferId";
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

            if (processdocId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "processdocId", processdocId)); // query parameter
            if (taskworkId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "taskworkId", taskworkId)); // query parameter

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
                Exception exception = ExceptionFactory("TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// This call returns the bufferId for document preview 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processdocId"></param>
        /// <param name="taskworkId"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferIdAsync (int? processdocId, int? taskworkId)
        {
             ApiResponse<string> localVarResponse = await TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferIdAsyncWithHttpInfo(processdocId, taskworkId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns the bufferId for document preview 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processdocId"></param>
        /// <param name="taskworkId"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferIdAsyncWithHttpInfo (int? processdocId, int? taskworkId)
        {
            // verify the required parameter 'processdocId' is set
            if (processdocId == null)
                throw new ApiException(400, "Missing required parameter 'processdocId' when calling TaskWorkDocumentsApi->TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferId");
            // verify the required parameter 'taskworkId' is set
            if (taskworkId == null)
                throw new ApiException(400, "Missing required parameter 'taskworkId' when calling TaskWorkDocumentsApi->TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferId");

            var localVarPath = "/api/TaskWorkDocuments/documentPreviewBufferId";
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

            if (processdocId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "processdocId", processdocId)); // query parameter
            if (taskworkId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "taskworkId", taskworkId)); // query parameter

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
                Exception exception = ExceptionFactory("TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}
