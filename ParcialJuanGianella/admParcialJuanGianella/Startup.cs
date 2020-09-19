using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admParcialJuanGianella.Startup))]
namespace admParcialJuanGianella
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
