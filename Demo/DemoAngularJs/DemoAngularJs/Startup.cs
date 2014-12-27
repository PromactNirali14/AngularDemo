using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoAngularJs.Startup))]
namespace DemoAngularJs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
