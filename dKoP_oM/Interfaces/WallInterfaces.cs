using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class WallInterfaces : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual WallBaseInterface BaseInterface { get; set; } = new WallBaseInterface();

        public virtual WallSideInterface SideInterface { get; set; } = new WallSideInterface();

        public virtual WallTopInterface TopInterface { get; set; } = new WallTopInterface();


        /***************************************************/
    }
}