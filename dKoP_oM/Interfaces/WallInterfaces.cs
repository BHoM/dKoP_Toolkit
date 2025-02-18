using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class WallInterfaces : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual WallBaseInterface BaseInterface { get; set; }

        public virtual WallSideInterface SideInterface { get; set; }

        public virtual WallTopInterface TopInterface { get; set; }


        /***************************************************/
    }
}