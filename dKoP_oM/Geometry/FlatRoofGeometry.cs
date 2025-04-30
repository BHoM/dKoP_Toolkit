using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class FlatRoofGeometry : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual SettingOut SettingOut { get; set; } = new SettingOut();

        public virtual FlatRoofDimensions ExternalDimensions { get; set; } = new FlatRoofDimensions();

        public virtual List<LoftHatchOpening> LoftHatchOpenings { get; set; } = new List<LoftHatchOpening>();

        /***************************************************/
    }
}