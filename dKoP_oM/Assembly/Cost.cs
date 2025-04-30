using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class Cost : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double UnitCost { get; set; }

        public virtual double Delivery { get; set; }

        public virtual double Other { get; set; }

        /***************************************************/
    }
}