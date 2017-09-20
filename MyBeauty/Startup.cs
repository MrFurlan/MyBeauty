using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBeauty.Startup))]
namespace MyBeauty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
