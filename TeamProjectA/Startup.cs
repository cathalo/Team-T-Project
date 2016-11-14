using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamProjectA.Startup))]
namespace TeamProjectA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
