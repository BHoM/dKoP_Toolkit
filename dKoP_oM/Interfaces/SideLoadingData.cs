using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class SideLoadingData : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [ForcePerUnitLength]
        public virtual double HorizontalOutOfPlaneLoadVariableMax { get; set; }

        [ForcePerUnitLength]
        public virtual double HorizontalOutOfPlaneLoadVariableMin { get; set; }

        /***************************************************/
    }
}