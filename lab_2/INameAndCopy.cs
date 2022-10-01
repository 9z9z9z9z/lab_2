using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    interface INameAndCopy
    {
        string Name { get; set; }
        object DeepCopy();
    }
}
