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

        public virtual Procurement Procurement { get; set; } = new Procurement();

        public virtual Delivery Delivery { get; set; } = new Delivery();

        public virtual Packaging Packaging { get; set; } = new Packaging();

        public virtual Construction Construction { get; set; } = new Construction();

        /***************************************************/
    }
}