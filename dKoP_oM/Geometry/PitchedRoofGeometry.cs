using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP.Geometry
{
    public class PitchedRoofGeometry : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual SettingOut SettingOut { get; set; }

        public virtual PitchedRoofDimensions ExternalDimensions { get; set; }

        public virtual List<IFloorAndRoofOpening> Voids { get; set; }

        /***************************************************/
    }
}