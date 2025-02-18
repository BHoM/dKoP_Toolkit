using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP.Geometry
{
    public class FloorGeometry : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual SettingOut SettingOut { get; set; }

        public virtual FloorDimensions ExternalDimensions { get; set; }

        public virtual List<IFloorAndRoofOpening> Voids { get; set; }

        /***************************************************/
    }
}