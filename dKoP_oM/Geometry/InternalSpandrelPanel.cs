using BH.oM.Quantities.Attributes;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class InternalSpandrelPanel : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Length]
        public virtual double Thickness { get; set; }

        /***************************************************/
    }
}