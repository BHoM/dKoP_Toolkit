using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;

namespace BH.oM.dKoP
{
    public class DoorAndWindowThermalPerformance : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double UValue { get; set; }

        public virtual double GValue { get; set; }

        /***************************************************/
    }
}