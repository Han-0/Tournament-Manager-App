﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary;

namespace TrackerUI
{
    public interface IPrizeRequestor
    {
        void prizeComplete(Prize model);
    }
}
