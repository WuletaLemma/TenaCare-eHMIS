﻿/*
 * 
 * Copyright © 2006-2017 TenaCareeHMIS  software, by The Administrators of the Tulane Educational Fund, 
 * dba Tulane University, Center for Global Health Equity is distributed under the GNU General Public License(GPL).
 * All rights reserved.

 * This file is part of TenaCareeHMIS
 * TenaCareeHMIS is free software: 
 * 
 * you can redistribute it and/or modify it under the terms of the 
 * GNU General Public License as published by the Free Software Foundation, 
 * version 3 of the License, or any later version.
 * TenaCareeHMIS is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or 
 * FITNESS FOR A PARTICULAR PURPOSE.See the GNU General Public License for more details.

 * You should have received a copy of the GNU General Public License along with TenaCareeHMIS.  
 * If not, see http://www.gnu.org/licenses/.    
 * 
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using Admin.Security.Model;
using Admin.Security.Utility;
using eHMISWebApi.Models;

namespace eHMISWebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class BIAnalyticsController : ApiController
    {       

        // GET api/bireports
        [System.Web.Http.AcceptVerbs("Get")]   
        public HttpResponseMessage ReportURIS()
        {

            Dictionary<String,String> powerBIReportURIS = new Dictionary<string, string> {
                { "TenaBI", "https://app.powerbi.com/view?r=eyJrIjoiYmJmMzM3NTMtYWEwYy00ZTllLWI5OGItMDkzY2ZjYWU0ZGYwIiwidCI6IjczNjRlZDlhLTdiOTQtNDA1NS04OWQ2LTdiZWM4ZmJiMTVlYyIsImMiOjh9"}
            };

            return this.Request.CreateResponse<Dictionary<String, String>>(powerBIReportURIS);            
            
        }
     
    }
}