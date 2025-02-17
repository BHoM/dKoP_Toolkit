using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP.Interfaces
{
    public class FloorAndRoofInterfaces : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual FloorAndRoofSideInterface SideA { get; set; }

        public virtual FloorAndRoofSideInterface SideB { get; set; }

        public virtual FloorAndRoofSideInterface SideC { get; set; }

        public virtual FloorAndRoofSideInterface SideD { get; set; }

        /***************************************************/
    }
}