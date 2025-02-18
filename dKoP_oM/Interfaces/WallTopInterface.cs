using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class WallTopInterface : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual TopInterfaceType InterfaceType { get; set; } = TopInterfaceType.Unknown;

        public virtual TopLoadingData LoadingData { get; set; }
        /***************************************************/
    }
}