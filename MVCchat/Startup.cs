using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCchat.Startup))]
namespace MVCchat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
