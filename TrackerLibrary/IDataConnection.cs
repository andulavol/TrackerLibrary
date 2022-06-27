using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}
