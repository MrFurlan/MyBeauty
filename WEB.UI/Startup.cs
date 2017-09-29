using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEB.UI.Startup))]
namespace WEB.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
