using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class HealthAndSafety : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual string SiteRelatedSignificantResidualRisks { get; set; } = "";

        public virtual string COSSHCertification { get; set; } = "";

        public virtual bool SafetyDataSheets { get; set; }

        public virtual string VOCTestAndEmissionsCertificate { get; set; } = "";

        public virtual string ProductSignificantResidualRisk { get; set; } = "";

        public virtual string StructuralCertification { get; set; } = "";

        /***************************************************/
    }
}