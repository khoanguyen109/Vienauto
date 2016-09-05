using Vienauto.Core.Extension;

namespace Vienauto.Mobile.Configuration
{
    public class AppSetting
    {
        public static string NhibernateConfig => ConfigExtensions<string>.GetValue("nhibernateConfig");
    }
}
