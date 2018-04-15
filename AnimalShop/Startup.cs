using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnimalShop.Startup))]
namespace AnimalShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
