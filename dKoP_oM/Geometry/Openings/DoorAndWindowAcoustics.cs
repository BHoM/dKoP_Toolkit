using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class DoorAndWindowAcoustics : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [WeightedSoundReductionIndex]
        [Description("Weighted sound reduction index, Rw.")]
        public virtual double AirborneSoundInsulation { get; set; }

        /***************************************************/
    }
}