﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public interface IScored
    {
        float Score { get; set; }
        float MaximumScore { get; set; }
    }
}
