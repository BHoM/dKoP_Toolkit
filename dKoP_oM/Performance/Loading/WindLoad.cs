using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class WindLoad : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Pressure]
        public virtual double PeakPressure { get; set; }

        /***************************************************/
    }
}