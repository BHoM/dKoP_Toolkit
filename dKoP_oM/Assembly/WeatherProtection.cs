using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.dKoP.Perfomance;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP.Assembly
{
    public class WeatherProtection : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual bool Integral { get; set; }

        public virtual bool RequiredBeforeEnclosedInBuilding { get; set; }

        /***************************************************/
    }
}