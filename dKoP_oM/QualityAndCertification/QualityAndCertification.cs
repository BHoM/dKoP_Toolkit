using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP.QualityAndCertification
{
    public class QualityAndCertification : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual string DLUHCPrincipalsDocumentReferenceNumber { get; set; } = "";

        public virtual string DLUHCPrincipalsDocumentReferenceVersion { get; set; } = "";

        public virtual bool CompliantWithDLUHCPrincipalsDocument { get; set; }

        public virtual string AssuranceSchemeName { get; set; } = "";

        public virtual string AssuranceCertification { get; set; } = "";

        /***************************************************/
    }
}