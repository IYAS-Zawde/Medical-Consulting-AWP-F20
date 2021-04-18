using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Medical_Consulting_AWP_F20.Startup))]
namespace Medical_Consulting_AWP_F20
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
