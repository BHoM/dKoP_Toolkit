using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class WallGeometry : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual SettingOut SettingOut { get; set; } = new SettingOut();

        public virtual WallDimensions ExternalDimensions { get; set; } = new WallDimensions();

        public virtual List<IWallOpening> Openings { get; set; } = new List<IWallOpening>();

        /***************************************************/
    }
}