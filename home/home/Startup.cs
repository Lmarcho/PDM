using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(home.Startup))]
namespace home
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
