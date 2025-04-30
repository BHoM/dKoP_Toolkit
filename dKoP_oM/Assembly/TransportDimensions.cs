using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class TransportDimensions : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Length]
        public virtual double Length { get; set; }

        [Length]
        public virtual double Width { get; set; }

        [Length]
        public virtual double Height { get; set; }

        /***************************************************/
    }
}