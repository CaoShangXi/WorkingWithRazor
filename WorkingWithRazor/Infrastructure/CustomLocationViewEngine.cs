using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkingWithRazor.Infrastructure
{
    public class CustomLocationViewEngine:RazorViewEngine
    {
        public CustomLocationViewEngine()
        {
            //配置视图搜索的位置，{0}表示视图名，{1}表示控制器名，{2}表示区域名
            ViewLocationFormats = new string[] { "~/Views/{1}/{0}.cshtml","~/Views/Common/{0}.cshtml"};
        }
    }
}