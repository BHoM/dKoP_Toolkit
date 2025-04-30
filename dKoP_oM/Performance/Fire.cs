using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class Fire : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual FireResistance FireResistance { get; set; } = new FireResistance();

        public virtual SurfaceSpreadOfFlame SurfaceSpreadOfFlame { get; set; } = new SurfaceSpreadOfFlame();
        /***************************************************/
    }
}