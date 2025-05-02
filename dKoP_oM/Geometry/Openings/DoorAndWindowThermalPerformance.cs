using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class DoorAndWindowThermalPerformance : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [ThermalTransmittance]
        public virtual double UValue { get; set; }

        [Ratio]
        public virtual double GValue { get; set; }

        /***************************************************/
    }
}