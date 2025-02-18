using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class Assembly : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual Procurement Procurement { get; set; }

        public virtual Delivery Delivery { get; set; }

        public virtual Packaging Packaging { get; set; }

        public virtual Construction Construction { get; set; }

        /***************************************************/
    }
}