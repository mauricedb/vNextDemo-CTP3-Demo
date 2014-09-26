using Microsoft.Framework.ConfigurationModel;
using System;
using System.Collections.Generic;

namespace vNextDemo
{
    /// <summary>
    /// Summary description for SimpleConfigurationSource
    /// </summary>
    public class SimpleConfigurationSource : IConfigurationSource
    {
        public SimpleConfigurationSource()
        {
        }

        public bool TryGet(string key, out string value)
        {
            if (key.Equals("path", StringComparison.OrdinalIgnoreCase))
            {
                value = "A fake path";
                return true;
            }

            value = null;
            return false;
        }

        public void Load()
        {
        }

        public IEnumerable<string> ProduceSubKeys(IEnumerable<string> earlierKeys, string prefix, string delimiter)
        {
            throw new NotImplementedException();
        }

        public void Set(string key, string value)
        {
            throw new NotImplementedException();
        }
    }
}