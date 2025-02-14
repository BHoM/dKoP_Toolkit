using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP.Perfomance
{
    public class AirborneSoundInsulation : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        //TODO: Add quantity
        public virtual double WeightedSoundReductionIndexWithReductionRwCtr { get; set; } = 40;

        public virtual string Documentation { get; set; } = "";

        /***************************************************/
    }
}