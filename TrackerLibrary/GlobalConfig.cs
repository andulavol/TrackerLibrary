using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections()
        {
            // TODO - set up the sql connector properly
            SqlConnector sql = new SqlConnector();
            Connection = sql;
        }
        public static string CnnString(string cnnstringname)
        {
            return ConfigurationManager.ConnectionStrings[cnnstringname].ConnectionString;
        }
        
    }

   
}
