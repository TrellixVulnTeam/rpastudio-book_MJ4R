﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPA.Interfaces.Nupkg
{
    public interface IPackageIdentityService
    {
        Task<List<string>> BuildDependentAssemblies(string pkgName,string pkgVer);
    }
}
