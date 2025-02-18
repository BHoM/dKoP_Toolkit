using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;

namespace BH.oM.dKoP
{
    public class SettingOut : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual string BuildingLevel { get; set; }

        public virtual Point ReferencePoint { get; set; }

        public virtual Point OrientationPoint { get; set; }

        /***************************************************/
    }
}