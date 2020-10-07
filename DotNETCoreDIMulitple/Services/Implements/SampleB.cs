using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNETCoreDIMultiple.Services.Interfaces;

namespace DotNETCoreDIMultiple.Services.Implements
{
    public class SampleB : ISample
    {
        public string Name => "SampleB";
        public string GetName()
        {
            return $"Hello, {this.GetName()}";
        }
    }
}
