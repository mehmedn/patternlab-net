﻿using System.Web;
using System.Web.Mvc;

namespace PatternLab.Web
{
    public class Application : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
        }
    }
}