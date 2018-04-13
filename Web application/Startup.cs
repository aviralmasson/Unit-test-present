using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_application.Startup))]
namespace Web_application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
