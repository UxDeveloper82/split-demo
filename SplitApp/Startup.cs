using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SplitApp.Startup))]
namespace SplitApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
