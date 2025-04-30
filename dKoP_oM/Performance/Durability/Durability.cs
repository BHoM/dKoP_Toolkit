using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class Durability : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual int DesignLife { get; set; } = 50;

        public virtual CorrosivityCategory OutdoorCorrosivityCategory { get; set; } = CorrosivityCategory.Undefined;

        /***************************************************/
    }
}