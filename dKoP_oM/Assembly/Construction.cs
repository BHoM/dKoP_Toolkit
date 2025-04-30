using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class Construction : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Mass]
        public virtual double Weight { get; set; }

        public virtual LiftingPoints LiftingPoints { get; set; } = new LiftingPoints();

        public virtual TemporaryWorks TemporaryWorks { get; set; } = new TemporaryWorks();

        public virtual WeatherProtection WeatherProtection { get; set; } = new WeatherProtection();

        /***************************************************/
    }
}