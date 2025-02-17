using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP.Interfaces
{
    public class WallBaseInterface : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual BaseInterfaceType InterfaceType { get; set; } = BaseInterfaceType.Unknown;

        /***************************************************/
    }
}