using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class Packaging : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual string Waste { get; set; }

        public virtual bool ReturnablePackaging { get; set; }

        /***************************************************/
    }
}