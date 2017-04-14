using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyDemo.Startup))]
namespace MyDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
