using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNETCoreDIMultiple.Services.Interfaces;

namespace DotNETCoreDIMultiple.Services.Implements
{
    public class SampleA : ISample
    {
        public string Name => "SampleA";

        public string GetName()
        {
            return $"Hi, {this.GetName()}";
        }

    }
}
