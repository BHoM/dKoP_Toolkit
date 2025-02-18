using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class TopLoadingData : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double VerticaLoadPermanentMax { get; set; }

        public virtual double VerticaLoadPermanentMin { get; set; }

        public virtual double VerticaLoadVariableMax { get; set; }

        public virtual double VerticaLoadVariableMin { get; set; }

        public virtual double HorizontalInPlaneLoadVariableMax { get; set; }
        
        public virtual double HorizontalInPlaneLoadVariableMin { get; set; }

        /***************************************************/
    }
}