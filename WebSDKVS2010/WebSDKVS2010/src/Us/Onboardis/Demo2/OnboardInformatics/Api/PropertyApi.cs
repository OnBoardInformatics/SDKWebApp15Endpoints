using System;
using System.Diagnostics;
using System.Collections.Generic;
using Us.Onboardis.Demo2.OnboardInformatics;
//using Us.Onboardis.Demo2.OnboardInformatics.Model;
namespace Us.Onboardis.Demo2.OnboardInformatics.Api {
  public class PropertyApi {
    string basePath;
    private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

    public PropertyApi(String basePath = "http://demo2.onboardis.us")
    {
      this.basePath = basePath;
    }

    public ApiInvoker getInvoker()
    {
      return apiInvoker;
    }

    // Sets the endpoint base url for the services being accessed
    public void setBasePath(string basePath)
    {
      this.basePath = basePath;
    }

    // Gets the endpoint base url for the services being accessed
    public String getBasePath()
    {
      return basePath;
    }

    

    /// <summary>
    ///    metadata
    /// </summary>
    /// <returns></returns>
    public string Metadata()
    {
      // create path and map variables
      var path = "/property/_metadata";

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

    // authentication setting
    bool requireAuth = false;

      try {
        if (typeof(void) == typeof(byte[])) {
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
          Debug.Write("Metadata response: " + response.ToString());
          return response.ToString();
        } else {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, null, headerParams, formParams, requireAuth);
          if(response != null){
              return response.ToString();
          }
          else {
              return response.ToString();
          }
        }
      } catch (ApiException ex) {
        if(ex.ErrorCode == 404) {
          return ex.Message;
        }
        else {
          throw ex;
        }
      }
    }

    /// <summary>
    ///    enumeration
    /// </summary>
    /// <returns></returns>
    public string Enumeration()
    {
      // create path and map variables
      var path = "/property/_enumeration/style";

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

    // authentication setting
    bool requireAuth = false;

      try {
        if (typeof(void) == typeof(byte[])) {
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
          Debug.Write("Enumeration response: " + response.ToString());
          return response.ToString();
        } else {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, null, headerParams, formParams, requireAuth);
          if(response != null){
              return response.ToString();
          }
          else {
              return response.ToString();
          }
        }
      } catch (ApiException ex) {
        if(ex.ErrorCode == 404) {
          return ex.Message;
        }
        else {
          throw ex;
        }
      }
    }

    /// <summary>
    ///   ID
    /// </summary>
    /// <returns></returns>
    public string Id()
    {
      // create path and map variables
      var path = "/property/id/10003111168/summary";

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

    // authentication setting
    bool requireAuth = false;

      try {
        if (typeof(void) == typeof(byte[])) {
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
          Debug.Write("Id response: " + response.ToString());
          return response.ToString();
        } else {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, null, headerParams, formParams, requireAuth);
          if(response != null){
              return response.ToString();
          }
          else {
              return response.ToString();
          }
        }
      } catch (ApiException ex) {
        if(ex.ErrorCode == 404) {
          return ex.Message;
        }
        else {
          throw ex;
        }
      }
    }

    /// <summary>
    ///   Apn
    /// </summary>
    /// <returns></returns>
    public string Apn()
    {
      // create path and map variables
      var path = "/property/apn/100030609100053";

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

    // authentication setting
    bool requireAuth = false;

      try {
        if (typeof(void) == typeof(byte[])) {
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
          Debug.Write("Apn response: " + response.ToString());
          return response.ToString();
        } else {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, null, headerParams, formParams, requireAuth);
          if(response != null){
              return response.ToString();
          }
          else {
              return response.ToString();
          }
        }
      } catch (ApiException ex) {
        if(ex.ErrorCode == 404) {
          return ex.Message;
        }
        else {
          throw ex;
        }
      }
    }

    /// <summary>
    ///   Address
    /// </summary>
    /// <param name="address">Address</param>
    /// <param name="filter">Filter</param>
    /// <returns></returns>
    public string Address (string address, string filter) {
      // create path and map variables
      var path = "/property/address";

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      if (address != null){
        formParams.Add ("address", ApiInvoker.parameterToString(address));
      }
      if (filter != null){
        formParams.Add ("filter", ApiInvoker.parameterToString(filter));
      }
    // authentication setting
    bool requireAuth = false;

      try {
        if (typeof(void) == typeof(byte[])) {
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
          Debug.Write("Address response: " + response.ToString());
          return response.ToString();
        } else {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, null, headerParams, formParams, requireAuth);
          if(response != null){
              return response.ToString();
          }
          else {
              return response.ToString();
          }
        }
      } catch (ApiException ex) {
        if(ex.ErrorCode == 404) {
          return ex.Message;
        }
        else {
          throw ex;
        }
      }
    }


    /// <summary>
    ///   AddressSummary
    /// </summary>
    /// <param name="address">Address</param>
    /// <param name="filter">Filter</param>
    /// <returns></returns>
    public string AddressSummary(string address, string filter)
    {
        // create path and map variables
        var path = "/property/address/summary";

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (address != null)
        {
            formParams.Add("address", ApiInvoker.parameterToString(address));
        }
        if (filter != null)
        {
            formParams.Add("filter", ApiInvoker.parameterToString(filter));
        }
        // authentication setting
        bool requireAuth = false;

        try
        {
            if (typeof(void) == typeof(byte[]))
            {
                var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
                Debug.Write("Address Summary response: " + response.ToString());
                return response.ToString();
            }
            else
            {
                var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, null, headerParams, formParams, requireAuth);
                if (response != null)
                {
                    return response.ToString();
                }
                else
                {
                    return response.ToString();
                }
            }
        }
        catch (ApiException ex)
        {
            if (ex.ErrorCode == 404)
            {
                return ex.Message;
            }
            else
            {
                throw ex;
            }
        }
    }

  }
}

