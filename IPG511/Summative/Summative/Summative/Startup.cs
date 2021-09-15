using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Summative.Startup))]
namespace Summative
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
