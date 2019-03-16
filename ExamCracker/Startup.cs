using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamCracker.Startup))]
namespace ExamCracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
