using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNETCoreDIMultiple.Services.Interfaces
{
    public interface ISample
    {
        string Name { get; }

        string GetName();
    }
}
