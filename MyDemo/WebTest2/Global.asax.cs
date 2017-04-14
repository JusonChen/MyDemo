using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebTest2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            StackExchange.Redis.ConfigurationOptions redisConfigOpts = StackExchange.Redis.ConfigurationOptions.Parse("127.0.0.1:6379");
            RedisSessionProvider.Config.RedisConnectionConfig.GetSERedisServerConfig = (HttpContextBase context) =>
            {
                return new KeyValuePair<string, StackExchange.Redis.ConfigurationOptions>(
                    "DefaultConnection",
                    redisConfigOpts);
            };
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
