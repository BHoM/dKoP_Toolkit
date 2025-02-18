using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;

namespace BH.oM.dKoP
{
    public class DoorFinish : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual OpeningPartFinish Exterior { get; set; } = new OpeningPartFinish();

        public virtual OpeningPartFinish Interior { get; set; } = new OpeningPartFinish();

        /***************************************************/
    }
}