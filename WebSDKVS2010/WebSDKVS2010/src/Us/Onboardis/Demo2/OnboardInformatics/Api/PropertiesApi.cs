using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using Us.Onboardis.Demo2.OnboardInformatics;
//using Us.Onboardis.Demo2.OnboardInformatics.Model;
namespace Us.Onboardis.Demo2.OnboardInformatics.Api {
  public class PropertiesApi {
    string basePath;
    private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

    public PropertiesApi(String basePath = "http://demo2.onboardis.us")
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
    ///   Summaryradius
    /// </summary>
    /// <returns></returns>
    public string SummaryRadius(string point, string radius, string unit, string page, string size)
    {
      // create path and map variables
      var path = "/properties/summary/radius";

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      if (point != null)
      {
          formParams.Add("point", ApiInvoker.parameterToString(point));
      }
      if (radius != null)
      {
          formParams.Add("radius", ApiInvoker.parameterToString(radius));
      }
      if (unit != null)
      {
          formParams.Add("unit", ApiInvoker.parameterToString(unit));
      }
      if (page != null)
      {
          formParams.Add("page", ApiInvoker.parameterToString(page));
      }
      if (size != null)
      {
          formParams.Add("size", ApiInvoker.parameterToString(size));
      }
     

    // authentication setting
    bool requireAuth = false;

      try {
        if (typeof(void) == typeof(byte[])) {
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
          Debug.Write("SummaryRadius response: " + response.ToString());
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
    ///   Summaryradius
    /// </summary>
    /// <returns></returns>
    public string SummaryRadiusAddress(string point, string radius, string unit, string page, string size)
    {
        // create path and map variables
        var path = "/properties/summary/radius";

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (point != null)
        {
            formParams.Add("point", ApiInvoker.parameterToString(point));
        }
        if (radius != null)
        {
            formParams.Add("radius", ApiInvoker.parameterToString(radius));
        }
        if (unit != null)
        {
            formParams.Add("unit", ApiInvoker.parameterToString(unit));
        }
        if (page != null)
        {
            formParams.Add("page", ApiInvoker.parameterToString(page));
        }
        if (size != null)
        {
            formParams.Add("size", ApiInvoker.parameterToString(size));
        }


        // authentication setting
        bool requireAuth = false;

        try
        {
            if (typeof(void) == typeof(byte[]))
            {
                var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
                Debug.Write("SummaryRadius response: " + response.ToString());
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


    /// <summary>
    ///   Summary
    /// </summary>
    /// <param name="postal">Postal</param>
    /// <returns></returns>
    public string Summary(string postal)
    {
      // create path and map variables
      var path = "/properties/summary/postal";

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      if (postal != null){
        formParams.Add ("postal", ApiInvoker.parameterToString(postal));
      }
    // authentication setting
    bool requireAuth = false;

      try {
        if (typeof(void) == typeof(byte[])) {
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
          Debug.Write("Summary response: " + response.ToString());
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
    ///   PostalAddress
    /// </summary>
    /// <returns></returns>
    public string PostalAddress(string postal, string page, string size, string filter)
    {
      // create path and map variables
        var path = "/properties/addresses/postal";

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

     if (postal != null){
        formParams.Add ("postal", ApiInvoker.parameterToString(postal));
      }
      if (page != null){
        formParams.Add ("page", ApiInvoker.parameterToString(page));
      }
      if (size != null)
      {
        formParams.Add("size", ApiInvoker.parameterToString(size));
      }
      if (filter != null){
        formParams.Add ("filter", ApiInvoker.parameterToString(filter));
      }

    // authentication setting
    bool requireAuth = false;

      try {
        if (typeof(void) == typeof(byte[])) {
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
          Debug.Write("PostalAddress response: " + response.ToString());
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
    ///   Ids
    /// </summary>
    /// <param name="postal">postal</param>
    /// <returns></returns>
    public string Ids(string postal)
    {
      // create path and map variables
        var path = "/properties/ids/postal";

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      if (postal != null)
      {
          formParams.Add("postal", ApiInvoker.parameterToString(postal));
      }
     
    // authentication setting
    bool requireAuth = false;

      try {
        if (typeof(void) == typeof(byte[])) {
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
          Debug.Write("Ids response: " + response.ToString());
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
    ///   Snapshots
    /// </summary>
    /// <param name="geoformat">Geoformat</param>
    /// <param name="geom">Geom</param>
    /// <param name="page">Page</param>
    /// <param name="size">Size</param>
    /// <returns></returns>
    public string Snapshots(string postal, string page, string size)
    {
      // create path and map variables
        var path = "/properties/snapshots/postal";

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      if (postal != null)
      {
          formParams.Add("postal", ApiInvoker.parameterToString(postal));
      }
      if (page != null){
        formParams.Add ("page", ApiInvoker.parameterToString(page));
      }
      if (size != null){
        formParams.Add ("size", ApiInvoker.parameterToString(size));
      }
    // authentication setting
    bool requireAuth = false;

      try {
        if (typeof(void) == typeof(byte[])) {
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
          Debug.Write("Snapshots response: " + response.ToString());
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
    ///   Summaries
    /// </summary>
    /// <param name="bbox">Bbox</param>
    /// <param name="page">Page</param>
    /// <param name="size">Size</param>
    /// <param name="filter">Filter</param>
    /// <returns></returns>
    public string Summaries(string bbox, string page, string size, string filter)
    {
      // create path and map variables
      var path = "/properties/summaries/bbox";

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      if (bbox != null){
        formParams.Add ("bbox", ApiInvoker.parameterToString(bbox));
      }
      if (page != null){
        formParams.Add ("page", ApiInvoker.parameterToString(page));
      }
      if (size != null){
        formParams.Add ("size", ApiInvoker.parameterToString(size));
      }
      if (filter != null){
        formParams.Add ("filter", ApiInvoker.parameterToString(filter));
      }
    // authentication setting
    bool requireAuth = false;

      try {
        if (typeof(void) == typeof(byte[])) {
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
          Debug.Write("Summaries response: " + response.ToString());
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
    ///   ZipSummaries
    /// </summary>
    /// <param name="zip">zip</param>
    /// <param name="page">Page</param>
    /// <param name="size">Size</param>
    /// <param name="filter">filter</param>
    /// <returns></returns>
    public string ZipSummaries(string zip, string page, string size, string filter)
    {
        // create path and map variables
        var path = "/properties/summaries/zip";

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (zip != null)
        {
            formParams.Add("zip", ApiInvoker.parameterToString(zip));
        }
        if (page != null)
        {
            formParams.Add("page", ApiInvoker.parameterToString(page));
        }
        if (size != null)
        {
            formParams.Add("size", ApiInvoker.parameterToString(size));
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
                Debug.Write("Summaries zip response: " + response.ToString());
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

    /// <summary>
    ///   SummariesPostal
    /// </summary>
    /// <param name="postal">postal</param>
    /// <param name="page">Page</param>
    /// <param name="size">Size</param>
    /// <returns></returns>
    public string SummariesPostal(string postal, string page, string size)
    {
        // create path and map variables
        var path = "/properties/summaries/postal";

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (postal != null)
        {
            formParams.Add("postal", ApiInvoker.parameterToString(postal));
        }
        if (page != null)
        {
            formParams.Add("page", ApiInvoker.parameterToString(page));
        }
        if (size != null)
        {
            formParams.Add("size", ApiInvoker.parameterToString(size));
        }
        // authentication setting
        bool requireAuth = false;

        try
        {
            if (typeof(void) == typeof(byte[]))
            {
                var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
                Debug.Write("Summaries Postal response: " + response.ToString());
                return response.ToString();
              
            }
            else
            {
                var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, null, headerParams, formParams, requireAuth);
                if (response != null)
                {
                    return "Total Count: " + response.Count().ToString() + "<br>" + response.ToString();
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

