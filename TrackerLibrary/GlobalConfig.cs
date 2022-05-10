using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections()
        {
            // TODO - set up the sql connector properly
            SqlConnector sql = new SqlConnector();
            Connections.Add(sql);
        }
    }
}
