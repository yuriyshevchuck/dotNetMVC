using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(yruiysApplication.Startup))]
namespace yruiysApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
