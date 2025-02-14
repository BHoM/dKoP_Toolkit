using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP.Perfomance
{
    public class Sustainability : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual string NRM2 { get; set; }

        public virtual string EPDCertification { get; set; }

        public virtual EmbodiedCarbon EmbodiedCarbon { get; set; }

        public virtual string SustainableSourcingCertification { get; set; }

        /***************************************************/
    }
}