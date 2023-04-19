using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public enum Skills
    {
        None,
        cooking,
        cleaning,
        [Description("solving conflicts")]
        solving,
        [Description("managing people")]
        managing
    }
}