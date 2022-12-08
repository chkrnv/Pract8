using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract8
{
    internal interface ISeries
    {
        int FirstValue { get; set; }
        int SecondValue { get; set; }
        double Step { get; set; }
    }
}
