using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LewisList.Startup))]
namespace LewisList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
