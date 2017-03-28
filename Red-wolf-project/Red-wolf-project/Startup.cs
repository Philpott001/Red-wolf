using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Red_wolf_project.Startup))]
namespace Red_wolf_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
