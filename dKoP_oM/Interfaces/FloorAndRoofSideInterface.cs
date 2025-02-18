using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class WallSideInterface : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual SideInterfaceType InterfaceType { get; set; } = SideInterfaceType.Unknown;

        public virtual SideLoadingData LoadingData { get; set; } = new SideLoadingData();

        /***************************************************/
    }
}