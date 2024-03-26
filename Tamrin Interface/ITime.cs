using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin_Interface
{
    internal interface ITime
    {
        string Time { get; set; }
        string Print();
    }
}
