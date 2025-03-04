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

        public virtual List<Door> Doors { get; set; } = new List<Door>();

        public virtual List<Window> Windows { get; set; } = new List<Window>();

        /***************************************************/
    }
}