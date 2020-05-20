using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Veterianria.Web.Startup))]
namespace Veterianria.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
