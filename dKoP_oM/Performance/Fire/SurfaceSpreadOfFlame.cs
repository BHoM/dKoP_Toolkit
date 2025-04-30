using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class SurfaceSpreadOfFlame : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual string ReactionToFireSmokePropagationFlamingDropletsAndParticles { get; set; } = "";

        public virtual string Documentation { get; set; } = "";

        /***************************************************/
    }
}