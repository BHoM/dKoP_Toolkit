using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;

namespace BH.oM.dKoP
{
    public class OpeningPartFinish : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual OpeningFinishMaterial FinishMaterial { get; set; }

        public virtual OpeningColour Colour { get; set; }

        /***************************************************/
    }
}