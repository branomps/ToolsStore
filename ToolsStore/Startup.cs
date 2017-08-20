using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToolsStore.Startup))]
namespace ToolsStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
