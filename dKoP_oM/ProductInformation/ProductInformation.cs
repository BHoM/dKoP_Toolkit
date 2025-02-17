using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP.ProductInformation
{
    public class ProductInformation : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual Buildup Buildup { get; set; }

        public virtual Documentation Documentation { get; set; }

        public virtual string OtherUSP { get; set; }

        /***************************************************/
    }
}