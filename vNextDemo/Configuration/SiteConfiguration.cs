using Microsoft.Framework.ConfigurationModel;
using System;
using System.Collections.Generic;

namespace vNextDemo
{
    /// <summary>
    /// Summary description for SiteConfiguration
    /// </summary>
    public class SiteConfiguration : IConfiguration
    {
        private Configuration _config;

	    public SiteConfiguration()
	    {
            // Setup configuration sources
            _config = new Configuration();
            _config.AddJsonFile("config.json");
            _config.AddEnvironmentVariables();
            _config.Add(new SimpleConfigurationSource());
        }

        public string this[string key]
        {
            get
            {
                return _config[key];
            }

            set
            {
                _config[key] = value;
            }
        }

        public void Commit()
        {
            _config.Commit();
        }

        public string Get(string key)
        {
            return _config.Get(key);
        }

        public IConfiguration GetSubKey(string key)
        {
            return _config.GetSubKey(key);
        }

        public IEnumerable<KeyValuePair<string, IConfiguration>> GetSubKeys()
        {
            return _config.GetSubKeys();
        }

        public IEnumerable<KeyValuePair<string, IConfiguration>> GetSubKeys(string key)
        {
            return _config.GetSubKeys(key);
        }

        public void Reload()
        {
            _config.Reload();
        }

        public void Set(string key, string value)
        {
            _config.Set(key, value);
        }

        public bool TryGet(string key, out string value)
        {
            return _config.TryGet(key, out value);
        }
    }
}