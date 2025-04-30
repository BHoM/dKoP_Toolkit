using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class AirPermeability : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double Permeability { get; set; }

        public virtual string Documentation { get; set; }

        /***************************************************/
    }
}