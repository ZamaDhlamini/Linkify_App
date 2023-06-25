using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain.Enum
{
    public enum RefListBranches : int
    {
        [Description("Soweto Branch")]
        Soweto = 0,
        /// <summary>
        /// 
        /// </summary>
        /// 
        [Description("Fourways Branch")]
        Fourways = 1,
        /// <summary>
        /// 
        /// </summary>
        /// 
        [Description("Chartwell Branch")]
        Chartwell = 2,
        /// <summary>
        /// 
        /// </summary>
        /// 
        [Description("Diepsloot Branch")]
        Diepsloot = 3,
    }
}
