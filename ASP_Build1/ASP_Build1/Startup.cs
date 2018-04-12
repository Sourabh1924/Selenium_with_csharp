using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Build1.Startup))]
namespace ASP_Build1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
