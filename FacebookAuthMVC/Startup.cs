using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacebookAuthMVC.Startup))]
namespace FacebookAuthMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
