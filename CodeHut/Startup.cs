using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeHut.Startup))]
namespace CodeHut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
