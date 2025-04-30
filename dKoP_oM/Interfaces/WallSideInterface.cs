using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class WallSideInterface : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual SideInterfaceType InterfaceType { get; set; } = SideInterfaceType.Unknown;

        /***************************************************/
    }
}