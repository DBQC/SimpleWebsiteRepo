using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleWebsite.Startup))]
namespace SimpleWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
