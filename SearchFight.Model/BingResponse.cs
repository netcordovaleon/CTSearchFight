﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFight.Model
{
    public class BingResponse
    {
        public BingWebPage webPages { get; set; }

    }

    public class BingWebPage
    {
        public long totalEstimatedMatches { get; set; }
    }
}
