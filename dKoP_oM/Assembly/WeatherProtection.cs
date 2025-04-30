using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class WeatherProtection : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual bool Integral { get; set; }

        public virtual bool RequiredBeforeEnclosedInBuilding { get; set; }

        /***************************************************/
    }
}