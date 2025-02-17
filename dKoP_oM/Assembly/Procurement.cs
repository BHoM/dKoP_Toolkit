using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP.Assembly
{
    public class Procurement : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double LeadTime { get; set; }

        public virtual Cost Cost { get; set; }

        public virtual int MinimumOrder { get; set; }

        public virtual int MaximumOrder { get; set; }

        /***************************************************/
    }
}