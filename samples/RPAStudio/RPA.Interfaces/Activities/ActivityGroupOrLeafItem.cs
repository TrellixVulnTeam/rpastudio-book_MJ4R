﻿using RPA.Interfaces.AppDomains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPA.Interfaces.Activities
{
    public class ActivityGroupOrLeafItem : MarshalByRefServiceBase
    {
        public string Name { get; set; }
    }
}
