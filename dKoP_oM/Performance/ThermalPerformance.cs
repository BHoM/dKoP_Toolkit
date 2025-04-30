using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class ThermalPerformance : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double UValue { get; set; }

        public virtual string Documentation { get; set; }

        /***************************************************/
    }
}