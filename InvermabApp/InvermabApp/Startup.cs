using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InvermabApp.Startup))]
namespace InvermabApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
