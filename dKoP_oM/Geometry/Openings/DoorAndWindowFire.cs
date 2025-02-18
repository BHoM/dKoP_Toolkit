using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;
using BH.oM.dKoP.Perfomance;
using BH.oM.Geometry;

namespace BH.oM.dKoP.Geometry
{
    public class DoorAndWindowFire : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual FireResistancePeriod FireResistance { get; set; } = FireResistancePeriod.EI30;

        [Description("Reaction to fire, smoke propagation, flaming droplets and particles.")]
        public virtual string SurfaceSpreadOfFlame { get; set; }

        /***************************************************/
    }
}