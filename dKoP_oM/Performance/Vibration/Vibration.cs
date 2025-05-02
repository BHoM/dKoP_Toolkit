using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class Vibration : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Frequency]
        public virtual double VibrationResponse { get; set; }

        [Ratio]
        public virtual double ResponseFactor { get; set; }

        /***************************************************/
    }
}