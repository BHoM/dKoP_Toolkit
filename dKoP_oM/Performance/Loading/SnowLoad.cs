using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class SnowLoad : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Pressure]
        public virtual double Uniform { get; set; }

        /***************************************************/
    }
}