using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP.Geometry
{
    public class WallGeometry : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual WallSettingOut SettingOut { get; set; }

        public virtual WallDimensions ExternalDimensions { get; set; }

        public virtual List<IWallOpening> Openings { get; set; }

        /***************************************************/
    }
}