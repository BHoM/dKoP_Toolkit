using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class FlatRoofGeometry : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual SettingOut SettingOut { get; set; } = new SettingOut();

        public virtual FlatRoofDimensions ExternalDimensions { get; set; } = new FlatRoofDimensions();

        public virtual List<IFloorAndRoofOpening> Voids { get; set; } = new List<IFloorAndRoofOpening>();

        /***************************************************/
    }
}