﻿using Domain.Socioboard.Domain;
using Socioboard.App_Start;
using Socioboard.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Socioboard.Controllers
{
    [CustomAuthorize]
    public class DiscoveryController : BaseController
    {
        //
        // GET: /Discovery/

        public ActionResult Index()
        {
            if (Session["User"] != null)
            {
               
                if (Session["Paid_User"].ToString() == "Unpaid")
                {
                    return RedirectToAction("Billing", "PersonalSetting");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Index");
            }
            //return View();
        }
        public ActionResult LoadDiscovery()
        {
            // Edited by Antima

            Domain.Socioboard.Domain.User objUser = (Domain.Socioboard.Domain.User)Session["User"];
            Api.DiscoverySearch.DiscoverySearch ApiobjDiscoverySearch = new Api.DiscoverySearch.DiscoverySearch();
            List<string> lstSearchHistory = new List<string>();
            lstSearchHistory = (List<string>)(new JavaScriptSerializer().Deserialize(ApiobjDiscoverySearch.getAllSearchKeywords(objUser.Id.ToString()), typeof(List<string>)));

            return PartialView("_DiscoveryPartial", lstSearchHistory);
        }

        public ActionResult SearchFacebook(string keyword)
        {
            keyword = Uri.EscapeDataString(keyword);
            Domain.Socioboard.Domain.User objUser = (Domain.Socioboard.Domain.User)Session["User"];
            Api.DiscoverySearch.DiscoverySearch ApiobjDiscoverySearch = new Api.DiscoverySearch.DiscoverySearch();
            List<Domain.Socioboard.Domain.DiscoverySearch> lstDiscoverySearch = new List<Domain.Socioboard.Domain.DiscoverySearch>();
            lstDiscoverySearch = (List<Domain.Socioboard.Domain.DiscoverySearch>)(new JavaScriptSerializer().Deserialize(ApiobjDiscoverySearch.DiscoverySearchFacebook(objUser.Id.ToString(), keyword), typeof(List<Domain.Socioboard.Domain.DiscoverySearch>)));
            return PartialView("_SearchFacebookPartial", lstDiscoverySearch);
        }
        public ActionResult SearchTwitter(string keyword)
        {
            keyword = Uri.EscapeDataString(keyword);
            Domain.Socioboard.Domain.User objUser = (Domain.Socioboard.Domain.User)Session["User"];
            Api.DiscoverySearch.DiscoverySearch ApiobjDiscoverySearch = new Api.DiscoverySearch.DiscoverySearch();
            List<Domain.Socioboard.Domain.DiscoverySearch> lstDiscoverySearch = new List<Domain.Socioboard.Domain.DiscoverySearch>();
            lstDiscoverySearch = (List<Domain.Socioboard.Domain.DiscoverySearch>)(new JavaScriptSerializer().Deserialize(ApiobjDiscoverySearch.DiscoverySearchTwitter(objUser.Id.ToString(), keyword), typeof(List<Domain.Socioboard.Domain.DiscoverySearch>)));
            return PartialView("_SearchTwitterPartial", lstDiscoverySearch);
        }

        public ActionResult SearchGplus(string keyword)
        {
            keyword = Uri.EscapeDataString(keyword);
            Domain.Socioboard.Domain.User objUser = (Domain.Socioboard.Domain.User)Session["User"];
            Api.DiscoverySearch.DiscoverySearch ApiobjDiscoverySearch = new Api.DiscoverySearch.DiscoverySearch();
            List<Domain.Socioboard.Domain.DiscoverySearch> GplusDiscoverySearch = new List<Domain.Socioboard.Domain.DiscoverySearch>();
            GplusDiscoverySearch = (List<Domain.Socioboard.Domain.DiscoverySearch>)(new JavaScriptSerializer().Deserialize(ApiobjDiscoverySearch.DiscoverySearchGplus(objUser.Id.ToString(), keyword), typeof(List<Domain.Socioboard.Domain.DiscoverySearch>)));
            return PartialView("_SearchGplusPartial", GplusDiscoverySearch);
        }
        public ActionResult SearchInstagram(string keyword)
        {
            keyword = keyword.Replace("#", "");
            keyword = Uri.EscapeDataString(keyword);
            Api.DiscoverySearch.DiscoverySearch ApiobjDiscoverySearch = new Api.DiscoverySearch.DiscoverySearch();
            List<Domain.Socioboard.MongoDomain.InstagramFeed> lstInstagramFeed = (List<Domain.Socioboard.MongoDomain.InstagramFeed>)(new JavaScriptSerializer().Deserialize(ApiobjDiscoverySearch.DiscoverySearchinstagram(keyword),typeof(List<Domain.Socioboard.MongoDomain.InstagramFeed>)));
            return PartialView("_SearchInstagramPartial", lstInstagramFeed);
        }

        public ActionResult GetUrls(string keywords)
        {
            Api.DiscoverySearch.DiscoverySearch apiLinkBuilder = new Api.DiscoverySearch.DiscoverySearch();
            List<string> _lstUrl = new List<string>();
            string[] keys = Regex.Split(keywords, ",");
            foreach (string item in keys)
            {
                try
                {
                    List<string> _lsttwt = (List<string>)new JavaScriptSerializer().Deserialize(apiLinkBuilder.TwitterLinkBuilder(item), typeof(List<string>));
                    if (_lsttwt.Count > 0)
                    {
                        _lstUrl.AddRange(_lsttwt);
                    }
                }
                catch { }
                try
                {
                    List<string> _lstgplus = (List<string>)new JavaScriptSerializer().Deserialize(apiLinkBuilder.GPlusLinkBuilder(item), typeof(List<string>));
                    if (_lstgplus.Count > 0)
                    {
                        _lstUrl.AddRange(_lstgplus);
                    }
                }
                catch { }
            }
            ExportUrlsToCSV(_lstUrl);
            return View();

        }
        public void ExportUrlsToCSV(List<string> _lst)
        {
            try
            {
                var details = new System.Data.DataTable("Urls");

                details.Columns.Add("Urls", typeof(string));
                foreach (string item_url in _lst)
                {
                    details.Rows.Add(item_url);
                }
                var grid = new GridView();
                grid.DataSource = details;
                grid.DataBind();
                Response.ClearContent();
                Response.Buffer = true;
                Response.AddHeader("content-disposition", "attachment; filename=Urls_" + (DateTime.Now.Ticks).ToString() + ".xls");
                Response.ContentType = "application/ms-excel";
                Response.Charset = "";
                StringWriter sw = new StringWriter();
                HtmlTextWriter htw = new HtmlTextWriter(sw);
                grid.RenderControl(htw);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

        }

        public async Task<ActionResult> SmartSearch()
        {
            User objUser = (User)Session["User"];
            string selectedgroupid = Session["group"].ToString();
            IEnumerable<Domain.Socioboard.Domain.Groupmembers> lstGroupMembers = new List<Domain.Socioboard.Domain.Groupmembers>();
            HttpResponseMessage response = await WebApiReq.GetReq("api/ApiGroupMembers/GetAcceptedGroupMembers?GroupId=" + selectedgroupid, "Bearer", Session["access_token"].ToString());
            if (response.IsSuccessStatusCode)
            {
                lstGroupMembers = await response.Content.ReadAsAsync<IEnumerable<Domain.Socioboard.Domain.Groupmembers>>();
            }

            return View(lstGroupMembers.ToList());
        }
        public ActionResult Searchtweets(string q, string geoLocation)
        {
            try
            {
                Api.DiscoverySearch.DiscoverySearch apiLinkBuilder = new Api.DiscoverySearch.DiscoverySearch();
                List<Domain.Socioboard.Helper.Discovery> lstDiscovery = new List<Domain.Socioboard.Helper.Discovery>();
                lstDiscovery = (List<Domain.Socioboard.Helper.Discovery>)new JavaScriptSerializer().Deserialize(apiLinkBuilder.TwitterTweetSearchWithGeoLocation(q, geoLocation), typeof(List<Domain.Socioboard.Helper.Discovery>));
                if (lstDiscovery.Count > 0)
                {
                    return PartialView("_SmartSearchPartial", lstDiscovery);
                }
                else {
                    return Content("no_data");
                }
            }
            catch (Exception ex)
            {
                return Content("no_data");
            }
        }
      
    }
}
