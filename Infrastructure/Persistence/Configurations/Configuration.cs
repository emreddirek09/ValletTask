﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Persistence.Configurations
{
    public class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                //ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../emre/Presentation/VALLETAPI"));

                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/Vallet.API"));

                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("DefaultConnectionMsSQL");
            }

        }
    }
}
