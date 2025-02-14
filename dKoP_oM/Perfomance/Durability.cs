using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP.Perfomance
{
    public class Durability : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual int DesignLife { get; set; } = 50;

        public virtual CorrosivityCategory OutdoorCorrosivityCategory { get; set; } = CorrosivityCategory.Undefined;

        /***************************************************/
    }
}