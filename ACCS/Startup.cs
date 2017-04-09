using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ACCS.Startup))]
namespace ACCS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
