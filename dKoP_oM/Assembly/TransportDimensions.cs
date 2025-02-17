using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP.Assembly
{
    public class TransportDimensions : IdKopObject
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