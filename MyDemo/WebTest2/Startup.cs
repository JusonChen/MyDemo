using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTest2.Startup))]
namespace WebTest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
