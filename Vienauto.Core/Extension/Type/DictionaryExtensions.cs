using System.Collections.Specialized;
using System.Linq;

namespace Vienauto.Core.Extension
{
    public static class DictionaryExtensions
    {
        public static NameValueCollection Replace(this NameValueCollection current, NameValueCollection replacements)
        {
            foreach (var key in replacements.AllKeys)
            {
                if (current.AllKeys.Contains(key))
                    current[key] = replacements[key];
                else
                    current.Add(key, replacements[key]);
            }
            return current;
        }
    }
}
