using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class ProductInformation : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual Buildup Buildup { get; set; } = new Buildup();

        public virtual Documentation Documentation { get; set; } = new Documentation();

        public virtual string OtherUSP { get; set; }

        /***************************************************/
    }
}