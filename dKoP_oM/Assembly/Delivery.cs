using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class Delivery : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual bool Standalone { get; set; }

        public virtual bool Palleted { get; set; }

        public virtual int NumberPerPallet { get; set; }

        public virtual TransportDimensions TransportDimensions { get; set; } = new TransportDimensions();

        public virtual bool Stackable { get; set; }

        public virtual int MaxNumberstacked { get; set; }

        /***************************************************/
    }
}