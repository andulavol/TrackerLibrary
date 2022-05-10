using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Fix CreatePrize
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.PrizeID = 1;

            return model;
        }
    }
}
