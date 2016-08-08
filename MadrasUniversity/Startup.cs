using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MadrasUniversity.Startup))]
namespace MadrasUniversity
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
