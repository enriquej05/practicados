using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace FunctionApp1
{
    public static class ConfigHelper
    {
        private static Settings settings;

        public static Settings Settings
        {
            get { if (settings != null) { 
                    return settings;
                }
                var config = new ConfigurationBuilder()
                        .AddJsonFile("local.settings.json")
                        .AddEnvironmentVariables()
                        .Build();
                settings = new Settings();
                config.Bind(settings);

                return settings;
            }
        }
    }
}
