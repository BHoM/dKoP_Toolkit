using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class PitchedRoofGeometry : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual SettingOut SettingOut { get; set; } = new SettingOut();

        public virtual PitchedRoofDimensions ExternalDimensions { get; set; } = new PitchedRoofDimensions();

        public virtual List<LoftHatchOpening> LoftHatchOpening { get; set; } = new List<LoftHatchOpening>();

        /***************************************************/
    }
}