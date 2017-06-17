using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiShop.Startup))]
namespace DiShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
