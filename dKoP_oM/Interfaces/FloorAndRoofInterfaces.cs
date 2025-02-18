using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class FloorAndRoofInterfaces : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual FloorAndRoofSideInterface SideA { get; set; } = new FloorAndRoofSideInterface();

        public virtual FloorAndRoofSideInterface SideB { get; set; } = new FloorAndRoofSideInterface();

        public virtual FloorAndRoofSideInterface SideC { get; set; } = new FloorAndRoofSideInterface();

        public virtual FloorAndRoofSideInterface SideD { get; set; } = new FloorAndRoofSideInterface();

        /***************************************************/
    }
}