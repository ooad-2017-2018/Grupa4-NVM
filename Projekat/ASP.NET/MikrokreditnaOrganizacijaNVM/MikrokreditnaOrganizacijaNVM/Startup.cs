using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MikrokreditnaOrganizacijaNVM.Startup))]
namespace MikrokreditnaOrganizacijaNVM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
