﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using NAA.Data;
using NAA.Services;
using NAA.Services.Service;

/// <summary>
/// Summary description for NAAWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class NAAWebService : System.Web.Services.WebService
{
    private NAA.Services.Service.ApplicationService _applicationService;
    public NAAWebService()
    {
        _applicationService = new NAA.Services.Service.ApplicationService();
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public List<Application> GetUniversityApplications(int uniID)
    {
        IList<Application> _res = _applicationService.GetUniversityApplications(uniID);
        return _res.ToList<Application>();
    }

    [WebMethod]
    public void ChangeUniversityOffer(int appId, string offer)
    {
        _applicationService.ChangeUniversityOffer(appId, offer);
    }

    [WebMethod]
    public Application GetApplicationDetails(int appId)
    {
        return _applicationService.GetApplicationDetails(appId);
    }
}
