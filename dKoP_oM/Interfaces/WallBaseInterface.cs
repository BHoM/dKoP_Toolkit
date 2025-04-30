using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class WallBaseInterface : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual BaseInterfaceType InterfaceType { get; set; } = BaseInterfaceType.Unknown;

        /***************************************************/
    }
}