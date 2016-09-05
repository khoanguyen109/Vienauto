using System;
using System.Configuration;

namespace Vienauto.Core.Extension
{
    public class ConfigExtensions<T>
    {
        private static T ConvertType(object value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }

        public static T GetValue(string key)
        {
            var keyType = typeof(T);
            var value = ConfigurationManager.AppSettings[key];
            try
            {
                if (keyType == typeof(bool) || keyType == typeof(string))
                {
                    if(!string.IsNullOrEmpty(value))
                        return ConvertType(value);
                }
                else if (keyType == typeof(string[]))
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        var arrayVals = value.Split(new Char[','], StringSplitOptions.RemoveEmptyEntries);
                        if (arrayVals != null && arrayVals.Length > 0)
                            return ConvertType(arrayVals);
                    }
                }
                return default(T);
            }
            catch (ArgumentException ex)
            {
                return default(T);
            }
        }
    }
}
