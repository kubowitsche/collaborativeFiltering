using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(collaborative_filtering.Startup))]
namespace collaborative_filtering
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
