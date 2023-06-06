using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain.Enum
{
    public enum RefListGender: int
    {
        [Description("1. Male")]
        Male = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("1. Female")]
        Female = 2,
        /// <summary>
        /// 
        /// </summary>
        [Description("0.Unknown")]
        NotDisclosed = 0
    }
}
