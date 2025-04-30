using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class FireResistance : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        //TODO: Add quantity
        public virtual FireResistancePeriod ResistanceClasification { get; set; } = FireResistancePeriod.REI30;

        public virtual string Documentation { get; set; } = "";

        /***************************************************/
    }
}