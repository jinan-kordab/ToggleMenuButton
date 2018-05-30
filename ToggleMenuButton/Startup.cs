using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToggleMenuButton.Startup))]
namespace ToggleMenuButton
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
