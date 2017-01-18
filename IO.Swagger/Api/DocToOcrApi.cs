/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No descripton provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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
    public interface IDocToOcrApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This method enqueue document to ocr
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns></returns>
        void DocToOcrDocToOcrQueue (int? docnumber);

        /// <summary>
        /// This method enqueue document to ocr
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DocToOcrDocToOcrQueueWithHttpInfo (int? docnumber);
        /// <summary>
        /// This method return the texts contained in specified document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns>List&lt;DocToOcrDTO&gt;</returns>
        List<DocToOcrDTO> DocToOcrGetByDocnumber (int? docnumber);

        /// <summary>
        /// This method return the texts contained in specified document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns>ApiResponse of List&lt;DocToOcrDTO&gt;</returns>
        ApiResponse<List<DocToOcrDTO>> DocToOcrGetByDocnumberWithHttpInfo (int? docnumber);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This method enqueue document to ocr
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DocToOcrDocToOcrQueueAsync (int? docnumber);

        /// <summary>
        /// This method enqueue document to ocr
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DocToOcrDocToOcrQueueAsyncWithHttpInfo (int? docnumber);
        /// <summary>
        /// This method return the texts contained in specified document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns>Task of List&lt;DocToOcrDTO&gt;</returns>
        System.Threading.Tasks.Task<List<DocToOcrDTO>> DocToOcrGetByDocnumberAsync (int? docnumber);

        /// <summary>
        /// This method return the texts contained in specified document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns>Task of ApiResponse (List&lt;DocToOcrDTO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<DocToOcrDTO>>> DocToOcrGetByDocnumberAsyncWithHttpInfo (int? docnumber);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DocToOcrApi : IDocToOcrApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DocToOcrApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DocToOcrApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocToOcrApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DocToOcrApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration {get; set;}

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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// This method enqueue document to ocr 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns></returns>
        public void DocToOcrDocToOcrQueue (int? docnumber)
        {
             DocToOcrDocToOcrQueueWithHttpInfo(docnumber);
        }

        /// <summary>
        /// This method enqueue document to ocr 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DocToOcrDocToOcrQueueWithHttpInfo (int? docnumber)
        {
            // verify the required parameter 'docnumber' is set
            if (docnumber == null)
                throw new ApiException(400, "Missing required parameter 'docnumber' when calling DocToOcrApi->DocToOcrDocToOcrQueue");

            var localVarPath = "/api/docToOcr/{docnumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (docnumber != null) localVarPathParams.Add("docnumber", Configuration.ApiClient.ParameterToString(docnumber)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DocToOcrDocToOcrQueue", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// This method enqueue document to ocr 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DocToOcrDocToOcrQueueAsync (int? docnumber)
        {
             await DocToOcrDocToOcrQueueAsyncWithHttpInfo(docnumber);

        }

        /// <summary>
        /// This method enqueue document to ocr 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DocToOcrDocToOcrQueueAsyncWithHttpInfo (int? docnumber)
        {
            // verify the required parameter 'docnumber' is set
            if (docnumber == null)
                throw new ApiException(400, "Missing required parameter 'docnumber' when calling DocToOcrApi->DocToOcrDocToOcrQueue");

            var localVarPath = "/api/docToOcr/{docnumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (docnumber != null) localVarPathParams.Add("docnumber", Configuration.ApiClient.ParameterToString(docnumber)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DocToOcrDocToOcrQueue", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// This method return the texts contained in specified document 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns>List&lt;DocToOcrDTO&gt;</returns>
        public List<DocToOcrDTO> DocToOcrGetByDocnumber (int? docnumber)
        {
             ApiResponse<List<DocToOcrDTO>> localVarResponse = DocToOcrGetByDocnumberWithHttpInfo(docnumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This method return the texts contained in specified document 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns>ApiResponse of List&lt;DocToOcrDTO&gt;</returns>
        public ApiResponse< List<DocToOcrDTO> > DocToOcrGetByDocnumberWithHttpInfo (int? docnumber)
        {
            // verify the required parameter 'docnumber' is set
            if (docnumber == null)
                throw new ApiException(400, "Missing required parameter 'docnumber' when calling DocToOcrApi->DocToOcrGetByDocnumber");

            var localVarPath = "/api/docToOcr/{docnumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (docnumber != null) localVarPathParams.Add("docnumber", Configuration.ApiClient.ParameterToString(docnumber)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DocToOcrGetByDocnumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<DocToOcrDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DocToOcrDTO>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DocToOcrDTO>)));
            
        }

        /// <summary>
        /// This method return the texts contained in specified document 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns>Task of List&lt;DocToOcrDTO&gt;</returns>
        public async System.Threading.Tasks.Task<List<DocToOcrDTO>> DocToOcrGetByDocnumberAsync (int? docnumber)
        {
             ApiResponse<List<DocToOcrDTO>> localVarResponse = await DocToOcrGetByDocnumberAsyncWithHttpInfo(docnumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This method return the texts contained in specified document 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="docnumber">The id of the document</param>
        /// <returns>Task of ApiResponse (List&lt;DocToOcrDTO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<DocToOcrDTO>>> DocToOcrGetByDocnumberAsyncWithHttpInfo (int? docnumber)
        {
            // verify the required parameter 'docnumber' is set
            if (docnumber == null)
                throw new ApiException(400, "Missing required parameter 'docnumber' when calling DocToOcrApi->DocToOcrGetByDocnumber");

            var localVarPath = "/api/docToOcr/{docnumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (docnumber != null) localVarPathParams.Add("docnumber", Configuration.ApiClient.ParameterToString(docnumber)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DocToOcrGetByDocnumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<DocToOcrDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DocToOcrDTO>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DocToOcrDTO>)));
            
        }

    }
}
