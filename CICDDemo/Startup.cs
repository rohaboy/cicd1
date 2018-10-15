using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CICDDemo.Startup))]
namespace CICDDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
