using ASPNETRoute.ModelBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.ModelBinding;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ASPNETRoute
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // 在应用程序启动时运行的代码
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
            //GlobalConfiguration.Configuration.Services.Add(typeof(ModelBinderProvider), new MyTypeConverterModelBinderProvider());


            //1.默认路由规则
            //RouteValueDictionary defaults = new RouteValueDictionary();
            //defaults.Add("name", "*");
            //defaults.Add("id", "*");
            //RouteTable.Routes.MapPageRoute("default", "employees/{name}/{id}", "~/Pages/RoutePages.aspx", false, defaults);

            //2.
            RouteValueDictionary defaults = new RouteValueDictionary {
                {"areacode","010" },
                {"days",2 }
            };
            RouteValueDictionary constaints = new RouteValueDictionary {
                {"areacode",@"0\d{2,3}" },
                {"days",@"[1-3]" }
            };
            RouteValueDictionary dataTokens = new RouteValueDictionary {
                {"defaultCity","BeiJing" },
                {"defaultDays",2 }
            };
            RouteTable.Routes.MapPageRoute("default", "{areacode}/{days}", "~/Pages/Weather.aspx", false, defaults, constaints, dataTokens);
        }
    }
}