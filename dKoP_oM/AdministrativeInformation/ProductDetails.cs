using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP.AdministrativeInformation
{
    public class ProductDetails : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual string ManufactureProductReference { get; set; } = "";

        public virtual string ManufactureProductDescription { get; set; } = "";

        /***************************************************/
    }
}
