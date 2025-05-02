using BH.oM.Quantities.Attributes;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class ParameterPoint : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Length]
        public virtual double U { get; set; }

        [Length]
        public virtual double V { get; set; }

        /***************************************************/
    }
}