using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace TestProject.Utils
{
    internal enum Role
    {
        Executive,
        Clinical,
        Financial,
        Operations,
        [Description("Technology/IT")]
        Technology,
        Other,
    }
}
