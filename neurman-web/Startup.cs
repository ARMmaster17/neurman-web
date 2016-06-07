using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(neurman_web.Startup))]
namespace neurman_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
