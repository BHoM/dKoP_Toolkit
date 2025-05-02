using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class ImpactSoundInsulation : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [WeightedSoundReductionIndex]
        public virtual double WeightedStandardisedImpactSoundPressureLevelAndSpectrumAdaptionFactorLnTwCtr { get; set; } = 40;

        public virtual string Documentation { get; set; } = "";

        /***************************************************/
    }
}