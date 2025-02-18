using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class Construction : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Mass]
        public virtual double Weight { get; set; }

        public virtual LiftingPoints LiftingPoints { get; set; }

        public virtual TemporaryWorks TemporaryWorks { get; set; }

        public virtual WeatherProtection WeatherProtection { get; set; }

        /***************************************************/
    }
}