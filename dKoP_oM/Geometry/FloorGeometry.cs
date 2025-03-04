using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class FloorGeometry : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual SettingOut SettingOut { get; set; } = new SettingOut();

        public virtual FloorDimensions ExternalDimensions { get; set; } = new FloorDimensions();

        public virtual List<Staircase> Staircases { get; set; } = new List<Staircase>();

        /***************************************************/
    }
}