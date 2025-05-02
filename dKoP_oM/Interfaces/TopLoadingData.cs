using BH.oM.Quantities.Attributes;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class TopLoadingData : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [ForcePerUnitLength]
        public virtual double VerticaLoadPermanentMax { get; set; }

        [ForcePerUnitLength]
        public virtual double VerticaLoadPermanentMin { get; set; }

        [ForcePerUnitLength]
        public virtual double VerticaLoadVariableMax { get; set; }

        [ForcePerUnitLength]
        public virtual double VerticaLoadVariableMin { get; set; }

        [ForcePerUnitLength]
        public virtual double HorizontalInPlaneLoadVariableMax { get; set; }

        [ForcePerUnitLength]
        public virtual double HorizontalInPlaneLoadVariableMin { get; set; }

        /***************************************************/
    }
}