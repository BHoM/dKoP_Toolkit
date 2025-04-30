using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class Vibration : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        //TODO: Add quantity
        public virtual double VibrationResponse { get; set; }

        public virtual double ResponseFactor { get; set; }

        /***************************************************/
    }
}